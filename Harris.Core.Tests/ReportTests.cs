using Harris.Core.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Tests
{
    [TestFixture]
    public class ReportTests
    {
        [Test]
        public void task_volume_should_return_zero_when_opps_is_zero()
        {
            var tv = new TaskVolume();

            Assert.AreEqual(0, tv.SuccessRate);
        }

        [Test]
        public void task_volume_should_correctly_calc_success_rate()
        {
            var tv = new TaskVolume { Defective = 1, Opportunities = 514 };

            Assert.AreEqual(0.9981M, decimal.Round(tv.SuccessRate, 4));
        }

        [Test]
        public void period_should_correctly_add_human_error_points()
        {
            var p = new Period
            {
                HumanErrorSev1Points = 1,
                HumanErrorSev2Points = 0.1M,
                HumanErrorSev3Points = 0.01M,
                HumanErrorSev1Volume = 1,
                HumanErrorSev2Volume = 0,
                HumanErrorSev3Volume = 1
            };

            Assert.AreEqual(1.01, p.HumanErrorPoints);
        }

    }
}
