﻿using System;
namespace Accounts.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}
