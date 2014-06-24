using Harris.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris.Core.Data {
  public interface ICompanyRepository {
    Company Get();
  }

  public class FakeCompanyRepository : ICompanyRepository {
    public Company Get() {
      var company = new Company {
        Name = "Harris",
        Contracts = new List<Contract> {
          new Contract {
             Name = "NMCI",
             Prime = false,
             ProgramManager = new Contact { Name = "Joe Somebody" },
             Customer = new Company { Name = "HP" },
             ContractNumber = "012345",
             TaskOrder = "012345",
             ContractVehicle = "GSA",
             ContractManager = new Contact { Name = "Joe Nobody" },
             Start = new DateTime(2000, 01, 01),
             End = new DateTime(2010, 09, 30),
             Description = "Integer blandit ullamcorper arcu in tincidunt. Maecenas at neque luctus ante tempor sagittis quis eu leo. Duis id ipsum dui. Ut nisi ipsum, fermentum eu tincidunt non, sollicitudin quis orci. Nulla vehicula suscipit nibh, fermentum ornare diam interdum et. Donec et nibh vel mi suscipit ornare at ullamcorper urna. Nunc quis gravida magna. Nunc tempus enim elit, id adipiscing eros porttitor vel. Suspendisse id venenatis nisi.",
             CPARs = new List<CPAR> {
               new CPAR { Name = CPAR.Criteria.QUALITY_OF_PRODUCT_SERVICE, Score = CPAR.Rating.EXCEPTIONAL },
               new CPAR { Name = CPAR.Criteria.SCHEDULE, Score = CPAR.Rating.EXCEPTIONAL },
               new CPAR { Name = CPAR.Criteria.COST_CONTROL, Score = CPAR.Rating.EXCEPTIONAL },
               new CPAR { Name = CPAR.Criteria.BUSINESS_RELATIONS, Score = CPAR.Rating.VERY_GOOD },
               new CPAR { Name = CPAR.Criteria.MANAGEMENT_OF_KEY_PERSONNEL, Score = CPAR.Rating.EXCEPTIONAL },
               new CPAR { Name = CPAR.Criteria.UTILIZATION_OF_SMALL_BUSINESS, Score = CPAR.Rating.EXCEPTIONAL },
             },
             Capabilities = new List<Capability> {
                new Capability { 
                  Id = 1,
                  Name = "C&A (DISA STIGs, DIACAP, FISMA"
                },
                new Capability { 
                  Id = 2,
                  Name = "Information Assurance Vulnerability Alert (IAVA)"
                },
                new Capability { 
                  Id = 3,
                  Name = "Configuration Control & Management"
                },
             }
          },
          new Contract {
             Name = "FAA FTI",
             Prime = true,
             ProgramManager = new Contact { Name = "Joe Somebody" },
             Customer = new Company { Name = "FAA" },
             ContractNumber = "012345",
             TaskOrder = "012345",
             ContractVehicle = "GSA",
             ContractManager = new Contact { Name = "Joe Nobody" },
             Start = new DateTime(2000, 01, 01),
             End = new DateTime(2017, 09, 30),
             Description = "Integer blandit ullamcorper arcu in tincidunt. Maecenas at neque luctus ante tempor sagittis quis eu leo. Duis id ipsum dui. Ut nisi ipsum, fermentum eu tincidunt non, sollicitudin quis orci. Nulla vehicula suscipit nibh, fermentum ornare diam interdum et. Donec et nibh vel mi suscipit ornare at ullamcorper urna. Nunc quis gravida magna. Nunc tempus enim elit, id adipiscing eros porttitor vel. Suspendisse id venenatis nisi.",
             CPARs = new List<CPAR> {
               new CPAR { Name = CPAR.Criteria.QUALITY_OF_PRODUCT_SERVICE, Score = CPAR.Rating.EXCEPTIONAL },
               new CPAR { Name = CPAR.Criteria.SCHEDULE, Score = CPAR.Rating.EXCEPTIONAL },
               new CPAR { Name = CPAR.Criteria.COST_CONTROL, Score = CPAR.Rating.EXCEPTIONAL },
               new CPAR { Name = CPAR.Criteria.BUSINESS_RELATIONS, Score = CPAR.Rating.EXCEPTIONAL },
               new CPAR { Name = CPAR.Criteria.MANAGEMENT_OF_KEY_PERSONNEL, Score = CPAR.Rating.EXCEPTIONAL },
               new CPAR { Name = CPAR.Criteria.UTILIZATION_OF_SMALL_BUSINESS, Score = CPAR.Rating.EXCEPTIONAL },
             },
             Capabilities = new List<Capability> {
                new Capability { 
                  Id = 1,
                  Name = "C&A (DISA STIGs, DIACAP, FISMA"
                },
                new Capability { 
                  Id = 2,
                  Name = "Information Assurance Vulnerability Alert (IAVA)"
                },
                new Capability { 
                  Id = 4,
                  Name = "Physical Security"
                }
             }
          },
        },
        Capabilities = new List<Capability> {
                new Capability { 
                  Id = 1,
                  Name = "C&A (DISA STIGs, DIACAP, FISMA"
                },
                new Capability { 
                  Id = 2,
                  Name = "Information Assurance Vulnerability Alert (IAVA)"
                },
                new Capability { 
                  Id = 3,
                  Name = "Configuration Control & Management"
                },
                new Capability { 
                  Id = 4,
                  Name = "Physical Security"
                }
             }
      };
      return company;
    }
  }
}
