using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public class Manager : Employee, IEmployee
    {
        public void ChangePhoneNumber(Client client, string phoneNumber) => client.PhoneNumber = phoneNumber;

        public void DetermineAccessLevel(Employee employee)
        {
        }
    }
}
