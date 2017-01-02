﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1
{
    public class UserIdentityDbContext : IdentityDbContext<User>
    {
        public UserIdentityDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
