using FatEntityOptions.Attributes;
using Xunit;

namespace FatEntityOptionsTests
{
    [Entity(PrimaryEntity = "User")]
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName => (FirstName + " " + LastName).Trim();

        public string Email { get; set; }

        public string Phone { get; set; }

        public string HomeAddress { get; set; }

        [Property(RefersTo = "Company.Id")]
        public int EmployerId { get; set; }

        [Property(RefersTo = "Company.Name")]
        public string EmployerName { get; set; }

        [Property(RefersTo = "User.Id")]
        public int SupervisorId { get; set; }

        [Property(RefersTo = "User.Name")]
        public string SupervisorName { get; set; }

        [Property(RefersTo = "User.Email")]
        public string SupervisorEmail { get; set; }

        [Property(RefersTo = "User.Phone")]
        public string SupervisorPhone { get; set; }
    }

    public class FatEntityOptions
    {
        [Fact]
        public void Test1()
        {

        }
    }
}
