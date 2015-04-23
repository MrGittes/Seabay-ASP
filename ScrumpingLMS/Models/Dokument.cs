﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ScrumpingLMS.Models
{
    public class Dokument
    {
        public int Id { get; set; }

        //Foreign Key ApplicationUserId
        public string ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [DisplayName("DokumentNamn")]
        public string DokumentName { get; set; }

        [DisplayName("Länk")]
        public string DokumentLink { get; set; }
    }
}