﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta._4.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<int>
    {
        public string Nickname { get; set; }
        public string Surname { get; set; }

    }
}
