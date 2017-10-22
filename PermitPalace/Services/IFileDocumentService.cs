using PermitPalace.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.Services
{
    public struct FileFindWhereParam
    {
        public string Personnel_DOD_ID { get; set; }
        public string Rank { get; set; }
        public string Approved_By_Supervisor_DOD_ID { get; set; }
        public string Document_Type { get; set; }
    }
    public interface IFileDocumentService
    {
        FILLED_DOCUMENT File(FILLED_DOCUMENT add);
        FILLED_DOCUMENT Remove(FILLED_DOCUMENT remove);
        FILLED_DOCUMENT Update(FILLED_DOCUMENT update);
        FILLED_DOCUMENT Get(Guid filed_guid);
        IEnumerable<FILLED_DOCUMENT> GetAll(FileFindWhereParam p);
        IEnumerable<FILLED_DOCUMENT> GetAllFromPersonnel(Guid personnel_id);
        /// <summary>
        /// Using the DocuSign API
        /// </summary>
        /// <param name="doc_to_sign"></param>
        /// <returns>The signed file docuent (After it is updated)</returns>
        FILLED_DOCUMENT SignDocument(FILLED_DOCUMENT doc_to_sign);

    }
    public class FileDocumentService : IFileDocumentService
    {
        ApplicationDbContext _context;
        public FileDocumentService(ApplicationDbContext ctx)
        {
            _context = ctx;
        }

        public FILLED_DOCUMENT File(FILLED_DOCUMENT add)
        {
            var file = _context.FILED_DOCUMENT.Add(add);
            _context.SaveChanges();
            return file.Entity;
        }
        public FILLED_DOCUMENT Get(Guid filed_guid)
        {
            return _context.FILED_DOCUMENT.FirstOrDefault(f => f.FILLED_DOCUMENT_GUID == filed_guid);
        }

        public IEnumerable<FILLED_DOCUMENT> GetAll(FileFindWhereParam p)
        {
            PERSONNEL_DATA owner = null;
            PERSONNEL_DATA super = null;
            if (!String.IsNullOrEmpty(p.Personnel_DOD_ID))
            {
                owner = _context.PERSONNEL_DATA.FirstOrDefault(f => f.DOD_NUMBER == p.Personnel_DOD_ID);
            }
            if(!String.IsNullOrEmpty(p.Approved_By_Supervisor_DOD_ID))
            {
                super = _context.PERSONNEL_DATA.FirstOrDefault(f => f.DOD_NUMBER == p.Approved_By_Supervisor_DOD_ID);
            }
            IEnumerable<FILLED_DOCUMENT> EndQuery = _context.FILED_DOCUMENT.Where(f => f.PDF_FILENAME == p.Document_Type);
            if(owner == null)
            {
                if (super == null) return EndQuery;
                else return EndQuery.Where(f => f.DOD_ID_OF_APPROVING_SUPERVISOR == p.Approved_By_Supervisor_DOD_ID);
            }
            else
            {
                return EndQuery.Where(f => f.PERSONNEL_OWNER == owner.PERSONNEL_ID);
            }
        }

        public IEnumerable<FILLED_DOCUMENT> GetAllFromPersonnel(Guid personnel_id)
        {
            return _context.FILED_DOCUMENT.Where(f => f.PERSONNEL_OWNER == personnel_id);
        }

        public FILLED_DOCUMENT Remove(FILLED_DOCUMENT remove)
        {
            var file = _context.FILED_DOCUMENT.Remove(remove);
            _context.SaveChanges();
            return file.Entity;
        }

        public FILLED_DOCUMENT SignDocument(FILLED_DOCUMENT doc_to_sign)
        {
            throw new NotImplementedException();
        }

        public FILLED_DOCUMENT Update(FILLED_DOCUMENT update)
        {
            var file = _context.FILED_DOCUMENT.Update(update);
            _context.SaveChanges();
            return file.Entity;
        }
    }
}
