﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DuringTravelAPI.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        
        public string Name { get; set; }
    }
}