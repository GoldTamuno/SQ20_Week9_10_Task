﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ContactBook.Model.Entities
{
          public class AppUser : IdentityUser
          {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
          public string? ImageUrl { get; set; }
            public string? FacebookUrl { get; set; }
            public string? TwitterUrl { get; set; }
            public string? City { get; set; }
            public string? State { get; set; }
            public string? Country { get; set; }
          }
    }
