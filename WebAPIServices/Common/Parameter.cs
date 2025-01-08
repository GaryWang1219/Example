﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIServices.Common
{
    public class Result<T>
    {
        public bool Success { get; set; }
        public int Code { get; set; }
        public string? Message { get; set; }
        public T? Content { get; set; }
    }
}
