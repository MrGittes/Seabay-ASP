using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ScrumpingLMS.Models
{
    public class ScheduleDayUpload
    {
        public int Id { get; set; }

        [DisplayName("Dag")]
        public int DayNumber { get; set; }

        //Foreign Key KlassId
        [DisplayName("Klass")]
        public int KlassId { get; set; }

        [ForeignKey("KlassId")]
        public virtual Klass Klass { get; set; }

        [DisplayName("DokumentNamn")]
        public string Dokumentnamn { get; set; }

        [DisplayName("Dokument")]
        public string LinkToDokument { get; set; }

    }
}