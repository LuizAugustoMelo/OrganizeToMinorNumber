﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OrganizeToMinorNumber.Entities.Exceptions
{
    class OrganizeExceptions : ApplicationException
    {
        public OrganizeExceptions(string message) : base(message) { }
    }
}
