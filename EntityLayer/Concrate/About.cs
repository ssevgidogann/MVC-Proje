﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class About

    {
        [Key]

        public int AboutID { get; set; }




        [StringLength(1000)]  
       public string AboutDetails { get; set; }
       
        [StringLength(1000)]
        public string AboutDetails2 { get; set; }

        
        [StringLength(1000)] 
        public string AboutImage { get; set; }

        [StringLength(1000)]
        public string AboutImage2 { get; set; }

    }
}
