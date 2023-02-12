using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public interface IEmployee : IPassportDataEditor
    {
        void ChangePhoneNumber(Client client, string phoneNumber);
    }
}
