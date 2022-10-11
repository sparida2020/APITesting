using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowApiTestAutomation.DTO
{
    public class ListOfUsersDTO
    {     
        public Guid id { get; set; }
        public string identifier { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string employeeNumber { get; set; }
        public string email { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public DateTimeOffset? ExpiryDate { get; set; }
        public string Timezone { get; set; }
        public bool Active { get; set; }
        public CustomData CustomData { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string LegalEntity { get; set; }
        public string Manager { get; set; }
        public string Mobile { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Role { get; set; }
    }

    public class CustomData
    {
        public string Preferredname { get; set; }
        public string Dynamicsempid { get; set; }
        public string Company { get; set; }
        public object Upn { get; set; }
    }
}
