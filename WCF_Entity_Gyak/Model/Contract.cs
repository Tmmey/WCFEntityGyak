﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WCF_Entity_Gyak.Model
{
    public class Contract
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ContractCreationDate { get; set; }

    }
}