﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public class Consultant : Employee, IEmployee
    {
        public void ChangePhoneNumber(Client client, string phoneNumber) => client.PhoneNumber = phoneNumber;
    }
}
