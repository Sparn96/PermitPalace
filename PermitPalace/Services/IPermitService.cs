using PermitPalace.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.Services
{
    public interface IPermitService
    {
        PERMIT_DATA Add(PERMIT_DATA add, string user);
        PERMIT_DATA Remove(PERMIT_DATA remove, string user);
        PERMIT_DATA Update(PERMIT_DATA update, string user);
        PERMIT_DATA Get(Guid permit_guid);
        IEnumerable<PERMIT_DATA> GetAllPermitsForPersonnel(Guid personnel_guid);
        IEnumerable<PERMIT_DATA> GetAllExpired();
    }
    public class PermitService : IPermitService
    {
        ApplicationDbContext _context;
        public PermitService(ApplicationDbContext ctx)
        {
            _context = ctx;
        }

        public PERMIT_DATA Add(PERMIT_DATA add, string user)
        {
            add.last_modified_by = user;
            add.date_last_modified = DateTime.Now;
            add.date_created = DateTime.Now;
            add.created_by = user;
            var p = _context.PERMIT_DATA.Add(add);
            _context.SaveChanges();
            return p.Entity;
        }

        public PERMIT_DATA Get(Guid permit_guid)
        {
            return _context.PERMIT_DATA.FirstOrDefault(f => f.PERMIT_GUID == permit_guid);
        }

        public IEnumerable<PERMIT_DATA> GetAllExpired()
        {
            return _context.PERMIT_DATA.Where(f => f.DATE_EXP < DateTime.Now);
        }

        public IEnumerable<PERMIT_DATA> GetAllPermitsForPersonnel(Guid personnel_guid)
        {
            return _context.PERMIT_DATA.Where(f => f.PERSONNEL_ID == personnel_guid);
        }

        public PERMIT_DATA Remove(PERMIT_DATA remove, string user)
        {
            remove.last_modified_by = user;
            remove.date_last_modified = DateTime.Now;
            var p = _context.PERMIT_DATA.Remove(remove);
            _context.SaveChanges();
            return p.Entity;
        }

        public PERMIT_DATA Update(PERMIT_DATA update, string user)
        {
            update.last_modified_by = user;
            update.date_last_modified = DateTime.Now;
            var p = _context.PERMIT_DATA.Update(update);
            _context.SaveChanges();
            return p.Entity;
        }
    }
}
