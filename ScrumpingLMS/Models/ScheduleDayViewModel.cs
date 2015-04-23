using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScrumpingLMS.Models
{
    public class ScheduleDayViewModel
    {
        public int Id { get; set; }

        [DisplayName("Dagnummer")]
        public int DayNumber { get; set; }

        [DisplayName("Datum")]
        public DateTime WorkingDate { get; set; }

        //Foreign Key KlassId
        public int KlassId { get; set; }

        [ForeignKey("KlassId")]
        public virtual Klass Klass { get; set; }

        [DisplayName("Dagsschema")]
        [AllowHtmlAttribute]
        public string Details { get; set; }

        [DisplayName("DokumentNamn")]
        public string DokumentName { get; set; }

        [DisplayName("Dokument")]
        public string LinkToDokument { get; set; }

        [DisplayName("Klassnamn")]
        public string Klassnamn { get; set; }
    }
}