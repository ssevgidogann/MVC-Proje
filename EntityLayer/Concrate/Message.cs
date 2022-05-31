﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class Message
    {
        [Key]
        public int MessageID { get; set; }

        [StringLength(50)] 
        public string SenderMail { get; set; }
        [StringLength(50)]
        public string ReceiverMail { get; set; }
        [StringLength(100)] 
        public string Subject { get; set; }
        public string MessageContact { get; set; }
        public DateTime MessageDate{ get; set; }
    }

}
