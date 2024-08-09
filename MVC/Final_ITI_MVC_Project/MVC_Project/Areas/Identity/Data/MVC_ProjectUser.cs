﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MVC_Project.Areas.Identity.Data;

// Add profile data for application users by adding properties to the MVC_ProjectUser class
public class MVC_ProjectUser : IdentityUser
{
    public string FristName { get; set; }
    public string LastName { get; set; }
}

