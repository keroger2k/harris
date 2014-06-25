namespace Harris.Core.Migrations {
  using Harris.Core.Models;
  using System;
  using System.Collections.Generic;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;

  internal sealed class Configuration : DbMigrationsConfiguration<Harris.Core.Data.DatabaseContext> {
    public Configuration() {
      AutomaticMigrationsEnabled = true;
      AutomaticMigrationDataLossAllowed = true;
    }

    protected override void Seed(Harris.Core.Data.DatabaseContext context) {
      context.Categories.AddOrUpdate(
        p => p.Name,
        new CapabilityCategory {
          Name = "Information Assurance",
          Capabilities = new List<Capability> {
            new Capability { Name = "Certification & Accreditation (C&A) (DISA STIGs, DIACAP, FISMA)" },
            new Capability { Name = "Information Assurance Vulnerability Alert (IAVA)" },
            new Capability { Name = "Configuration Control & Management" },
            new Capability { Name = "Physical Security" },
            new Capability { Name = "Virus Scanning"},
            new Capability { Name = "Computer Security Awareness and Training"},
            new Capability { Name = "Security Incident Response"},
            new Capability { Name = "Security Architecture Design"},
            new Capability { Name = "Remote Monitoring/Intrusion Detection" },
            new Capability { Name = "Risk Assessments" }
          }
        },
        new CapabilityCategory {
          Name = "IT Services", 
          Capabilities = new List<Capability> {
            new Capability { Name = "Change Management"},
            new Capability { Name = "Configuration Management"},
            new Capability { Name = "Capacity Planning"},
            new Capability { Name = "Computer-Aided Design/Computer–Aided Manufacturing (CAD/CAM)"},
            new Capability { Name = "Data & Media Management"},
            new Capability { Name = "Design Specs for Information Dissemination"},
            new Capability { Name = "Independent Verification & Validation (IV&V)"},
            new Capability { Name = "Web Application Development"},
            new Capability { Name = "Simulation and Modeling"},
            new Capability { Name = "Statistical Analysis"},
            new Capability { Name = "Systems Improvement and Software Maintenance"},
            new Capability { Name = "Systems Programming"},
            new Capability { Name = "Application Programming"},
            new Capability { Name = "Contingency Planning"},
            new Capability { Name = "Continuity of Operations (COOP)"},
            new Capability { Name = "Disaster Recovery"},
            new Capability { Name = "Systems Design"},
            new Capability { Name = "Product Integration"},
            new Capability { Name = "System Standards and Procedures"},
            new Capability { Name = "Solution Architecture"},
            new Capability { Name = "Reverse Engineering"},
            new Capability { Name = "Systems Conversion"},
            new Capability { Name = "Software Engineering"},
            new Capability { Name = "Software Life Cycle Management"},
            new Capability { Name = "System Quality Assurance"},
            new Capability { Name = "Systems Analysis"},
            new Capability { Name = "Desktop Support"},
            new Capability { Name = "End User Support"},
            new Capability { Name = "Office Automation Support"},
          }
        },
        new CapabilityCategory {
          Name = "Training", 
          Capabilities = new List<Capability> {
            new Capability { Name = "User Training"},
            new Capability { Name = "Design & Modeling & Simulation"},
          }
        },
        new CapabilityCategory {
          Name = "System O&M",
          Capabilities = new List<Capability> {
            new Capability { Name = "Infrastructure maintenance: mainframes, printers, tape drives"},
            new Capability { Name = "Backup Support"},
            new Capability { Name = "Commercial Off-the-Shelf (COTS) Support"},
            new Capability { Name = "Systems Administration"},
            new Capability { Name = "Configuration Management"},
            new Capability { Name = "Network Sustainment (LAN, WAN, BAN, VPN, PKI,DNS, WINS)"},
            new Capability { Name = "Enterprise Architecture Design and Maintenance"},
            new Capability { Name = "Wireless Networking"},
            new Capability { Name = "Develop and Maintain Network Diagrams"},
            new Capability { Name = "Video Conference"},
            new Capability { Name = "Secure Video Conferencing"},
            new Capability { Name = "Teleconferencing"},
            new Capability { Name = "Voice Over Internet Protocol (VoIP)"},
          }
        },
        new CapabilityCategory {
          Name = "Additional Management", 
          Capabilities = new List<Capability> {
            new Capability { Name = "Quality Assurance Surveillance Plan (QASP)"},
            new Capability { Name = "Continual Service Improvement"},
            new Capability { Name = "Associate Contractor Agreements"},
            new Capability { Name = "Conflict Resolution"},
            new Capability { Name = "Subcontractor Management"},
            new Capability { Name = "Risk Management Plan"},
            new Capability { Name = "Program Management Review (PMR/IPR)"},
            new Capability { Name = "Integrated Master Schedule (IMS)"},
            new Capability { Name = "Phased Schedule Planning"},
            new Capability { Name = "Scheduling Tools"},
            new Capability { Name = "Situational Awareness"},
            new Capability { Name = "Information Technology Service Management (ITSM)"},
            new Capability { Name = "Logistics"},
            new Capability { Name = "Demilitarization"},
            new Capability { Name = "Disposal"},
            new Capability { Name = "Warranty Management"},
            new Capability { Name = "Environmental Safety and Occupational Health"},
            new Capability { Name = "Packaging, Handling, Storage, and Transportation"},
          }
        }
      );
    }
  }
}
