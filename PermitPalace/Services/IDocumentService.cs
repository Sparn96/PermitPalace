using Microsoft.AspNetCore.Mvc.Rendering;
using PermitPalace.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.Services
{
    public interface IDocumentService
    {
        DOCUMENT_DATA Add(DOCUMENT_DATA add, string user);
        DOCUMENT_DATA Update(DOCUMENT_DATA update, string user);
        DOCUMENT_DATA Remove(DOCUMENT_DATA remove, string user);
        DOCUMENT_DATA Get(Guid document_guid);
        DOCUMENT_DATA GetByName(string name);
        IEnumerable<DOCUMENT_DATA> GetAll();
    }
    public class DocumentService : IDocumentService
    {
        ApplicationDbContext _context;
        public DocumentService(ApplicationDbContext ctx)
        {
            _context = ctx;
        }

        public DOCUMENT_DATA Add(DOCUMENT_DATA add, string user)
        {
            add.last_modified_by = user;
            add.date_last_modified = DateTime.Now;
            add.date_created = DateTime.Now;
            add.created_by = user;
            var doc = _context.DOCUMENTS.Add(add);
            _context.SaveChanges();
            return doc.Entity;
        }

        public DOCUMENT_DATA Get(Guid document_guid)
        {
            return _context.DOCUMENTS.FirstOrDefault(f => f.DOCUEMNT_GUID == document_guid);
        }

        public IEnumerable<DOCUMENT_DATA> GetAll()
        {
            return _context.DOCUMENTS;
        }
        //Should be unique -- one basic dox exists for each permit
        public DOCUMENT_DATA GetByName(string name)
        {
            return _context.DOCUMENTS.FirstOrDefault(f => f.DOCUMENT_NAME == name);
        }



        public DOCUMENT_DATA Remove(DOCUMENT_DATA remove, string user)
        {
            remove.last_modified_by = user;
            remove.date_last_modified = DateTime.Now;
            var doc = _context.DOCUMENTS.Remove(remove);
            _context.SaveChanges();
            return doc.Entity;
        }

        public DOCUMENT_DATA Update(DOCUMENT_DATA update, string user)
        {
            update.last_modified_by = user;
            update.date_last_modified = DateTime.Now;
            var doc = _context.DOCUMENTS.Update(update);
            _context.SaveChanges();
            return doc.Entity;
        }
    }
}
