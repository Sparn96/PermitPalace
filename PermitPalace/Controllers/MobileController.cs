using Microsoft.AspNetCore.Mvc;
using PermitPalace.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermitPalace.Controllers
{
    /// <summary>
    /// The mobile API that will
    /// </summary>
    public struct MobileLogin
    {
        public string dod_id { get; set; }
        public string device_id { get; set; }
    }

    public class MobileController : Controller
    {
        IPersonnelService _PersonnelService;
        public MobileController(IPersonnelService ips)
        {
            _PersonnelService = ips;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Login([FromBody]MobileLogin log)
        {

            return Json(_PersonnelService.GetBasicInformation(log.dod_id));
            
        }
    }
}
