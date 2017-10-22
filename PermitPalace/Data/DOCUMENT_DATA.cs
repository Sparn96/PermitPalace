using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.Data
{
    public class DOCUMENT_DATA : DatabaseTable
    {
        [Key]
        public Guid DOCUEMNT_GUID { get; set; }
        public string DOCUMENT_NAME { get; set; }
        public bool REQUIRES_SIGNATURE { get; set; }
    }
    public class FILLED_DOCUMENT : DatabaseTable
    {
        [Key]
        public Guid FILLED_DOCUMENT_GUID { get; set; }
        public Guid DOCUMENT_GUID { get; set; }
        public bool IS_SIGNED { get; set; }
        public bool IS_APPROVED { get; set; }
        public Guid PERSONNEL_OWNER { get; set; }
        public string DOD_ID_OF_APPROVING_SUPERVISOR { get; set; }
        public DateTime DATE_SIGNED { get; set; }
        public string PDF_FILENAME { get; set; }
        public string DOCUMENT_NAME { get; set; }
        public Guid PERMIT_GUID { get; set; }
    }
}
