﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squiggle.Plugins.Authentication
{
    public class AuthenticationResult
    {
        public AuthenticationStatus Status { get; set; }
        public UserDetails UserDetails { get; set; }
    }
}
