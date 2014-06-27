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

      //add capabilties
      context.Categories.AddOrUpdate(
        p => p.Name,
        GetCategories()
      );

      //save
      context.SaveChanges();

      var harris = new Company { Name = "Harris" };
      //create company
      context.Companies.AddOrUpdate(c => c.Name, harris);

      //add contracts to harris
      foreach (var item in GetContracts()) { harris.Contracts.Add(item); }

      //save
      context.SaveChanges();

      //Add capabilities to FAA
      var faa = harris.Contracts.Single(c => c.Name.Equals("FAA FTI", StringComparison.OrdinalIgnoreCase));
      foreach (var item in GetFAAFTICaps(context)) { 
        faa.Capabilities.Add(item);
        faa.PastPerformances.Add(new PastPerformance {
          Capability = item,
          Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis eleifend tristique nunc, at ornare nulla egestas ac. Mauris aliquet lacus vitae dui aliquet tempor. Maecenas vestibulum metus porttitor, feugiat massa et, sagittis justo. Maecenas sit amet lectus velit. Duis elementum justo nec suscipit vestibulum. Donec vulputate, neque id aliquet bibendum, dui sapien volutpat lorem, ut fringilla ipsum est a odio. Nulla aliquam sagittis elementum. Etiam eleifend interdum libero, vitae pulvinar risus adipiscing non. Vestibulum eget mattis velit. Sed ultricies ac eros at dapibus. Nunc malesuada cursus nisl, eu tristique ligula pharetra vitae. Mauris at rutrum sapien, a pellentesque leo."
        });
      }

      //Add capabilities to NMCI
      var NMCI = harris.Contracts.Single(c => c.Name.Equals("NMCI", StringComparison.OrdinalIgnoreCase));
      foreach (var item in GetNMCI(context)) { 
        NMCI.Capabilities.Add(item);
        NMCI.PastPerformances.Add(new PastPerformance {
          Capability = item,
          Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis eleifend tristique nunc, at ornare nulla egestas ac. Mauris aliquet lacus vitae dui aliquet tempor. Maecenas vestibulum metus porttitor, feugiat massa et, sagittis justo. Maecenas sit amet lectus velit. Duis elementum justo nec suscipit vestibulum. Donec vulputate, neque id aliquet bibendum, dui sapien volutpat lorem, ut fringilla ipsum est a odio. Nulla aliquam sagittis elementum. Etiam eleifend interdum libero, vitae pulvinar risus adipiscing non. Vestibulum eget mattis velit. Sed ultricies ac eros at dapibus. Nunc malesuada cursus nisl, eu tristique ligula pharetra vitae. Mauris at rutrum sapien, a pellentesque leo."
        });
      }

      //Add capabilities to NMCI/CoSC
      var CoSC = harris.Contracts.Single(c => c.Name.Equals("NMCI/CoSC", StringComparison.OrdinalIgnoreCase));
      foreach (var item in GetNMCI(context)) { 
        CoSC.Capabilities.Add(item);
        CoSC.PastPerformances.Add(new PastPerformance {
          Capability = item,
          Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis eleifend tristique nunc, at ornare nulla egestas ac. Mauris aliquet lacus vitae dui aliquet tempor. Maecenas vestibulum metus porttitor, feugiat massa et, sagittis justo. Maecenas sit amet lectus velit. Duis elementum justo nec suscipit vestibulum. Donec vulputate, neque id aliquet bibendum, dui sapien volutpat lorem, ut fringilla ipsum est a odio. Nulla aliquam sagittis elementum. Etiam eleifend interdum libero, vitae pulvinar risus adipiscing non. Vestibulum eget mattis velit. Sed ultricies ac eros at dapibus. Nunc malesuada cursus nisl, eu tristique ligula pharetra vitae. Mauris at rutrum sapien, a pellentesque leo."
        });
      }

      //Add capabilities to NRO
      var NRO = harris.Contracts.Single(c => c.Name.Equals("NRO Patriot", StringComparison.OrdinalIgnoreCase));
      foreach (var item in GetNRO(context)) { 
        NRO.Capabilities.Add(item);
        NRO.PastPerformances.Add(new PastPerformance {
          Capability = item,
          Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis eleifend tristique nunc, at ornare nulla egestas ac. Mauris aliquet lacus vitae dui aliquet tempor. Maecenas vestibulum metus porttitor, feugiat massa et, sagittis justo. Maecenas sit amet lectus velit. Duis elementum justo nec suscipit vestibulum. Donec vulputate, neque id aliquet bibendum, dui sapien volutpat lorem, ut fringilla ipsum est a odio. Nulla aliquam sagittis elementum. Etiam eleifend interdum libero, vitae pulvinar risus adipiscing non. Vestibulum eget mattis velit. Sed ultricies ac eros at dapibus. Nunc malesuada cursus nisl, eu tristique ligula pharetra vitae. Mauris at rutrum sapien, a pellentesque leo."
        });

      }


      //Add capabilities to DeCA
      var DeCA = harris.Contracts.Single(c => c.Name.Equals("DeCA", StringComparison.OrdinalIgnoreCase));
      foreach (var item in GetDeCA(context)) {
        DeCA.Capabilities.Add(item);
        DeCA.PastPerformances.Add(new PastPerformance {
          Capability = item,
          Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis eleifend tristique nunc, at ornare nulla egestas ac. Mauris aliquet lacus vitae dui aliquet tempor. Maecenas vestibulum metus porttitor, feugiat massa et, sagittis justo. Maecenas sit amet lectus velit. Duis elementum justo nec suscipit vestibulum. Donec vulputate, neque id aliquet bibendum, dui sapien volutpat lorem, ut fringilla ipsum est a odio. Nulla aliquam sagittis elementum. Etiam eleifend interdum libero, vitae pulvinar risus adipiscing non. Vestibulum eget mattis velit. Sed ultricies ac eros at dapibus. Nunc malesuada cursus nisl, eu tristique ligula pharetra vitae. Mauris at rutrum sapien, a pellentesque leo."
        });
      }

      //save
      context.SaveChanges();
    }


    private Contract[] GetContracts() {
      return new List<Contract> {
          new Contract {
             Name = "NMCI",
             Prime = false,
             ProgramManager = "Joe Nobody",
             Customer = "HP",
             ContractNumber = "012345",
             TaskOrder = "012345",
             ContractVehicle = "GSA",
             ContractManager = "Joe Nobody",
             Start = new DateTime(2000, 01, 01),
             End = new DateTime(2010, 09, 30),
             CPARs = new List<CPAR> {
               new CPAR { Name = CPAR.Criteria.QUALITY_OF_PRODUCT_SERVICE, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.SCHEDULE, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.COST_CONTROL, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.BUSINESS_RELATIONS, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.MANAGEMENT_OF_KEY_PERSONNEL, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.UTILIZATION_OF_SMALL_BUSINESS, Score = CPAR.Rating.NA },
             },
          },
          new Contract {
             Name = "NMCI/CoSC",
             Prime = false,
             ProgramManager = "Joe Nobody",
             Customer = "HP",
             ContractNumber = "012345",
             TaskOrder = "012345",
             ContractVehicle = "GSA",
             ContractManager = "Joe Nobody",
             Start = new DateTime(2000, 01, 01),
             End = new DateTime(2014, 09, 30),
             CPARs = new List<CPAR> {
               new CPAR { Name = CPAR.Criteria.QUALITY_OF_PRODUCT_SERVICE, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.SCHEDULE, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.COST_CONTROL, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.BUSINESS_RELATIONS, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.MANAGEMENT_OF_KEY_PERSONNEL, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.UTILIZATION_OF_SMALL_BUSINESS, Score = CPAR.Rating.NA },
             },
          },
          new Contract {
             Name = "FAA FTI",
             Prime = false,
             ProgramManager = "Joe Nobody",
             Customer = "FAA",
             ContractNumber = "012345",
             TaskOrder = "012345",
             ContractVehicle = "GSA",
             ContractManager = "Joe Nobody",
             Start = new DateTime(2000, 01, 01),
             End = new DateTime(2017, 09, 30),
             CPARs = new List<CPAR> {
               new CPAR { Name = CPAR.Criteria.QUALITY_OF_PRODUCT_SERVICE, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.SCHEDULE, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.COST_CONTROL, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.BUSINESS_RELATIONS, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.MANAGEMENT_OF_KEY_PERSONNEL, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.UTILIZATION_OF_SMALL_BUSINESS, Score = CPAR.Rating.NA },
             },
          },
          new Contract {
             Name = "NRO Patriot",
             Prime = true,
             ProgramManager = "Joe Nobody",
             Customer = "NRO",
             ContractNumber = "012345",
             TaskOrder = "012345",
             ContractVehicle = "GSA",
             ContractManager = "Joe Nobody",
             Start = new DateTime(2004, 09, 01),
             End = new DateTime(2012, 01, 15),
             CPARs = new List<CPAR> {
               new CPAR { Name = CPAR.Criteria.QUALITY_OF_PRODUCT_SERVICE, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.SCHEDULE, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.COST_CONTROL, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.BUSINESS_RELATIONS, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.MANAGEMENT_OF_KEY_PERSONNEL, Score = CPAR.Rating.NA },
               new CPAR { Name = CPAR.Criteria.UTILIZATION_OF_SMALL_BUSINESS, Score = CPAR.Rating.NA },
             },
          },
          new Contract {
             Name = "DeCA",
             Prime = true,
             ProgramManager = "Joe Nobody",
             Customer = "DeCA",
             ContractNumber = "012345",
             TaskOrder = "012345",
             ContractVehicle = "GSA",
             ContractManager = "Joe Nobody",
             Start = new DateTime(2001, 01, 01),
             End = new DateTime(2014, 09, 30),
             CPARs = new List<CPAR> {
               new CPAR { Name = CPAR.Criteria.QUALITY_OF_PRODUCT_SERVICE, Score = CPAR.Rating.EXCEPTIONAL },
               new CPAR { Name = CPAR.Criteria.SCHEDULE, Score = CPAR.Rating.EXCEPTIONAL },
               new CPAR { Name = CPAR.Criteria.COST_CONTROL, Score = CPAR.Rating.VERY_GOOD },
               new CPAR { Name = CPAR.Criteria.BUSINESS_RELATIONS, Score = CPAR.Rating.EXCEPTIONAL },
               new CPAR { Name = CPAR.Criteria.MANAGEMENT_OF_KEY_PERSONNEL, Score = CPAR.Rating.EXCEPTIONAL },
               new CPAR { Name = CPAR.Criteria.UTILIZATION_OF_SMALL_BUSINESS, Score = CPAR.Rating.NA },
             },
          }

      }.ToArray();
    }

    private CapabilityCategory[] GetCategories() {
      return new List<CapabilityCategory> {
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
            new Capability { Name = "Transition Stories"},
          }
        }
      }.ToArray();
    }

    private Capability[] GetFAAFTICaps(Harris.Core.Data.DatabaseContext context) {
      var caps = new string[] { "Certification & Accreditation (C&A) (DISA STIGs, DIACAP, FISMA)",
"Configuration Control & Management",
"Physical Security",
"Virus Scanning",
"Computer Security Awareness and Training",
"Security Incident Response",
"Security Architecture Design",
"Remote Monitoring/Intrusion Detection",
"Risk Assessments",
"Change Management",
"Configuration Management",
"Capacity Planning",
"Data & Media Management",
"Design Specs for Information Dissemination",
"Web Application Development",
"Simulation and Modeling",
"Statistical Analysis",
"Systems Improvement and Software Maintenance",
"Systems Programming",
"Contingency Planning",
"Continuity of Operations (COOP)",
"Disaster Recovery",
"Systems Design",
"Product Integration",
"System Standards and Procedures",
"Solution Architecture",
"Systems Conversion",
"Software Engineering",
"Software Life Cycle Management",
"System Quality Assurance",
"Systems Analysis",
"User Training",
"Design & Modeling & Simulation",
"Infrastructure maintenance: mainframes, printers, tape drives",
"Backup Support",
"Commercial Off-the-Shelf (COTS) Support",
"Systems Administration",
"Configuration Management",
"Network Sustainment (LAN, WAN, BAN, VPN, PKI,DNS, WINS)",
"Enterprise Architecture Design and Maintenance",
"Wireless Networking",
"Develop and Maintain Network Diagrams",
"Continual Service Improvement",
"Associate Contractor Agreements",
"Conflict Resolution",
"Subcontractor Management",
"Risk Management Plan",
"Program Management Review (PMR/IPR)",
"Integrated Master Schedule (IMS)",
"Scheduling Tools",
"Logistics",
"Transition Stories"};
      return context.Capabilities.Where(c => caps.Contains(c.Name)).ToArray();
    }
    private Capability[] GetNMCI(Harris.Core.Data.DatabaseContext context) {
      var caps = new string[] { "Systems Programming",
"User Training",
"Certification & Accreditation (C&A) (DISA STIGs, DIACAP, FISMA)",
"Information Assurance Vulnerability Alert (IAVA)",
"Configuration Control & Management",
"Security Incident Response",
"Security Architecture Design",
"Remote Monitoring/Intrusion Detection",
"Risk Assessments",
"Change Management",
"Configuration Management",
"Capacity Planning",
"Web Application Development",
"Simulation and Modeling",
"Systems Improvement and Software Maintenance",
"Application Programming",
"Contingency Planning",
"Continuity of Operations (COOP)",
"Disaster Recovery",
"Systems Design",
"Product Integration",
"System Standards and Procedures",
"Solution Architecture",
"Software Engineering",
"Software Life Cycle Management",
"Backup Support",
"Commercial Off-the-Shelf (COTS) Support",
"Systems Administration",
"Configuration Management",
"Network Sustainment (LAN, WAN, BAN, VPN, PKI,DNS, WINS)",
"Enterprise Architecture Design and Maintenance",
"Wireless Networking",
"Develop and Maintain Network Diagrams",
"Voice Over Internet Protocol (VoIP)",
"Continual Service Improvement",
"Conflict Resolution",
"Subcontractor Management",
"Program Management Review (PMR/IPR)",
"Phased Schedule Planning",
"Scheduling Tools",
"Situational Awareness",
"Information Technology Service Management (ITSM)",
"Logistics",
"Demilitarization",
"Warranty Management",
"Packaging, Handling, Storage, and Transportation",
"Transition Stories"
 };
      return context.Capabilities.Where(c => caps.Contains(c.Name)).ToArray();
    }
    private Capability[] GetNRO(Harris.Core.Data.DatabaseContext context) {
      var caps = new string[] { "Computer-Aided Design/Computer–Aided Manufacturing (CAD/CAM)",
"Design Specs for Information Dissemination",
"Simulation and Modeling",
"Design & Modeling & Simulation",
"Certification & Accreditation (C&A) (DISA STIGs, DIACAP, FISMA)",
"Information Assurance Vulnerability Alert (IAVA)",
"Configuration Control & Management",
"Physical Security",
"Virus Scanning",
"Computer Security Awareness and Training",
"Security Incident Response",
"Remote Monitoring/Intrusion Detection",
"Risk Assessments",
"Change Management",
"Configuration Management",
"Capacity Planning",
"Data & Media Management",
"Independent Verification & Validation (IV&V)",
"Web Application Development",
"Statistical Analysis",
"Systems Improvement and Software Maintenance",
"Systems Programming",
"Application Programming",
"Contingency Planning",
"Continuity of Operations (COOP)",
"Disaster Recovery",
"Systems Design",
"Product Integration",
"System Standards and Procedures",
"Solution Architecture",
"Systems Conversion",
"Software Engineering",
"Software Life Cycle Management",
"System Quality Assurance",
"Systems Analysis",
"Desktop Support",
"End User Support",
"Office Automation Support",
"User Training",
"Infrastructure maintenance: mainframes, printers, tape drives",
"Backup Support",
"Commercial Off-the-Shelf (COTS) Support",
"Systems Administration",
"Configuration Management",
"Network Sustainment (LAN, WAN, BAN, VPN, PKI,DNS, WINS)",
"Enterprise Architecture Design and Maintenance",
"Wireless Networking",
"Develop and Maintain Network Diagrams",
"Video Conference",
"Secure Video Conferencing",
"Teleconferencing",
"Voice Over Internet Protocol (VoIP)",
"Quality Assurance Surveillance Plan (QASP)",
"Continual Service Improvement",
"Associate Contractor Agreements",
"Conflict Resolution",
"Subcontractor Management",
"Program Management Review (PMR/IPR)",
"Integrated Master Schedule (IMS)",
"Phased Schedule Planning",
"Scheduling Tools",
"Situational Awareness",
"Information Technology Service Management (ITSM)",
"Logistics",
"Demilitarization",
"Disposal",
"Warranty Management",
"Environmental Safety and Occupational Health",
"Packaging, Handling, Storage, and Transportation",
"Transition Stories"
 };
      return context.Capabilities.Where(c => caps.Contains(c.Name)).ToArray();
    }
    private Capability[] GetDeCA(Harris.Core.Data.DatabaseContext context) {
      var caps = new string[] { "Certification & Accreditation (C&A) (DISA STIGs, DIACAP, FISMA)",
"Information Assurance Vulnerability Alert (IAVA)",
"Configuration Control & Management",
"Virus Scanning",
"Security Incident Response",
"Security Architecture Design",
"Remote Monitoring/Intrusion Detection",
"Risk Assessments",
"Change Management",
"Configuration Management",
"Capacity Planning",
"Independent Verification & Validation (IV&V)",
"Continuity of Operations (COOP)",
"Disaster Recovery",
"Systems Design",
"Product Integration",
"System Standards and Procedures",
"Solution Architecture",
"Desktop Support",
"End User Support",
"Infrastructure maintenance: mainframes, printers, tape drives",
"Commercial Off-the-Shelf (COTS) Support",
"Systems Administration",
"Configuration Management",
"Network Sustainment (LAN, WAN, BAN, VPN, PKI,DNS, WINS)",
"Wireless Networking",
"Develop and Maintain Network Diagrams",
"Video Conference",
"Secure Video Conferencing",
"Teleconferencing",
"Voice Over Internet Protocol (VoIP)",
"Quality Assurance Surveillance Plan (QASP)",
"Continual Service Improvement",
"Associate Contractor Agreements",
"Subcontractor Management",
"Program Management Review (PMR/IPR)",
"Information Technology Service Management (ITSM)",
"Logistics",
"Warranty Management",
"Transition Stories",
 };
      return context.Capabilities.Where(c => caps.Contains(c.Name)).ToArray();
    }
  }
}
