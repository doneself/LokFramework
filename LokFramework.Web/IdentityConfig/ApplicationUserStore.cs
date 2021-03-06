﻿using LokFramework.Web.IdentityConfig.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LokFramework.Web.IdentityConfig
{
    public class ApplicationUserStore: UserStore<ApplicationUser>
    {
        public ApplicationUserStore(ApplicationDbContext context) : base(context)
        {
        }
    }
}