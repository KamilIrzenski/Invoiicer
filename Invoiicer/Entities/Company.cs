﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicer.Entities
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string TaxNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZIPCode { get; set; }
        public string FlatNumber { get; set; }
    }
}