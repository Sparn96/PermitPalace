using PermitPalace.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.Services
{
    public interface IPersonnelService
    {
        //PERSONNEL_DATA Add(BasicPersonnelData basic_data);
        PERSONNEL_DATA Add(PERSONNEL_DATA data);
        PERSONNEL_DATA Update(PERSONNEL_DATA update);
        PERSONNEL_DATA Remove(PERSONNEL_DATA remove);
        PERSONNEL_DATA Get(string DOD_NUMBER);
        IEnumerable<PERSONNEL_DATA> FindByName(string full_name);
        IEnumerable<PERSONNEL_DATA> FindByDOB(DateTime dob);
        IEnumerable<PERSONNEL_DATA> FindByPlaceOfBirth(string place);
       // PERSONNEL_DATA FindByPermitNumber(string number); // assuming the permit number is a one to one
        IEnumerable<PERSONNEL_DATA> FindByRank(string rank);
    }
    public class PersonnelService : IPersonnelService
    {
        ApplicationDbContext _context;
        public PersonnelService(ApplicationDbContext ctx)
        {
            _context = ctx;
        }

        //public PERSONNEL_DATA Add(BasicPersonnelData basic_data)  //use basic data as referecne when building templtwe
        //{
        //    PERSONNEL_DATA data = new PERSONNEL_DATA();
        //    data.FIRST_NAME = basic_data.FIRST_NAME;
        //    data.LAST_FIRST_MI = basic_data.LAST_FIRST + " " + basic_data.MIDDLE_INITIAL;
        //    data.HEIGHT_IN_INCHES =  basic_data.HEIGHT_IN_INCHES;
        //    data.HOME_OF_RECORD =  basic_data.HOME_OF_RECORD;
        //}

        public PERSONNEL_DATA Add(PERSONNEL_DATA data)
        {
            var da = _context.PERSONNEL_DATA.Add(data);
            _context.SaveChanges();
            return da.Entity;
        }

        public IEnumerable<PERSONNEL_DATA> FindByDOB(DateTime dob)
        {
            return _context.PERSONNEL_DATA.Where(f => f.DOB.Year == dob.Year && f.DOB.DayOfYear == dob.DayOfYear);
        }

        public IEnumerable<PERSONNEL_DATA> FindByName(string full_name)
        {
            throw new NotImplementedException();
            //need to build a union list of all the possible names?
        }

        //public PERSONNEL_DATA FindByPermitNumber(string number)
        //{
        //    return _context.PERSONNEL_DATA.FirstOrDefault(f => f.number)
        //}

        public IEnumerable<PERSONNEL_DATA> FindByPlaceOfBirth(string place)
        {
            return _context.PERSONNEL_DATA.Where(f => f.PLACE_OF_BIRTH == place);
        }

        public IEnumerable<PERSONNEL_DATA> FindByRank(string rank)
        {
            return _context.PERSONNEL_DATA.Where(f => f.RANK == rank);
        }

        public PERSONNEL_DATA Get(string DOD_NUMBER)
        {
            return _context.PERSONNEL_DATA.FirstOrDefault(f => f.DOD_NUMBER == DOD_NUMBER);
        }

        public PERSONNEL_DATA Remove(PERSONNEL_DATA remove)
        {
            var da = _context.PERSONNEL_DATA.Remove(remove);
            _context.SaveChanges();
            return da.Entity;
        }

        public PERSONNEL_DATA Update(PERSONNEL_DATA update)
        {
            var da = _context.PERSONNEL_DATA.Update(update);
            _context.SaveChanges();
            return da.Entity;
        }
    }
}
