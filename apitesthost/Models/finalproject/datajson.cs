﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apitesthost.Models
{
     
    public class signUpreturnvalues:SignInreturnvalues
    {
        public Boolean Registered { get; set; }
       
    }

    public class SignInreturnvalues
    {
        public string UserID { get; set; }
        public string Status { get; set; }
    }

}
