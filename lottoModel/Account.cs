﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace lotto_DB.lottoModel
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string AccountFullName { get; set; }
        public DateTime? AccountBirthday { get; set; }
        public string AccountEmail { get; set; }
        public string AccountTel { get; set; }
        public string AccountUserName { get; set; }
        public string AccountPassword { get; set; }
        public DateTime? AccountCreateDate { get; set; }
        public string AccountCreateby { get; set; }
        public DateTime? AccountUpdateDate { get; set; }
        public string AccountUpdateby { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}