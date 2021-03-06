﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Models
{

    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Measurement { get; set; }

        public decimal DefaultHumanErrorSev1Points { get; set; }
        public decimal DefaultHumanErrorSev2Points { get; set; }
        public decimal DefaultHumanErrorSev3Points { get; set; }

        public int DefaultHumanErrorSev1Volume { get; set; }
        public int DefaultHumanErrorSev2Volume { get; set; }
        public int DefaultHumanErrorSev3Volume { get; set; }

        public int DefaultEmployees { get; set; }
        public decimal DefaultFunctionalQualityWeight { get; set; }
        public decimal DefaultHumanErrorWeight { get; set; }

        public bool EnableStretchTarget { get; set; }
        public bool EnableThreeMonthAverage { get; set; }
        public bool EnableSixMonthAverage { get; set; }

        public decimal Target { get; set; }
        public decimal StretchTarget { get; set; }

        public virtual ICollection<Period> Periods { get; set; }
        public virtual ICollection<VolumeTasks> Tasks { get; set; }

    }

    public class VolumeTasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Period
    {
        public int Id { get; set; }
        public DateTime Month { get; set; }

        public decimal HumanErrorSev1Points { get; set; }
        public decimal HumanErrorSev2Points { get; set; }
        public decimal HumanErrorSev3Points { get; set; }

        public int HumanErrorSev1Volume { get; set; }
        public int HumanErrorSev2Volume { get; set; }
        public int HumanErrorSev3Volume { get; set; }

        public int Employees { get; set; }
        public decimal FunctionalQualityWeight { get; set; }
        public decimal HumanErrorWeight { get; set; }

        public virtual ICollection<TaskVolume> Volumes { get; set; }
        public decimal HumanErrorPoints
        {
            get
            {
                return this.HumanErrorSev1Points * HumanErrorSev1Volume +
                       this.HumanErrorSev2Points * HumanErrorSev2Volume +
                       this.HumanErrorSev3Points * HumanErrorSev3Volume;
            }
        }
    }

    public class TaskVolume
    {
        public int Id { get; set; }
        public int Opportunities { get; set; }
        public int Defective { get; set; }

        public decimal SuccessRate
        {
            get
            {
                return (this.Opportunities == 0) ? 0 
                    : 1 - (this.Defective / (decimal)this.Opportunities);
            }
        }

        public virtual VolumeTasks Task { get; set; }
    }

    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Status> Statuses { get; set; }

    }

    public class Employee
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

    public class StatusTag
    {
        public int TagId { get; set; }
        public int StatusId { get; set; }

        public override string ToString()
        {
            return string.Format("TagId: {0}, StatusId: {1}", this.TagId, this.StatusId);
        }
    }

    public class Status
    {
        public int Id { get; set; }
        public DateTime StatusDate { get; set; }
        public bool Result { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
