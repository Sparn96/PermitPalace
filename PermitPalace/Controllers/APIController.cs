﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PermitPalace.Services;

namespace PermitPalace.Controllers
{
    public class APIController : Controller
    {
        IFileDocumentService _FiledDocumentService;
        public APIController(IFileDocumentService ifds)
        {
            _FiledDocumentService = ifds;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Signed(string id)
        {
            var doc = _FiledDocumentService.Get(Guid.Parse(id));
            doc.IS_SIGNED = true;
           // Console.WriteLine("\n" + d.@event);
            _FiledDocumentService.Update(doc, "DOCUSIGN");
            return RedirectToAction("Index", "Home");
        }
        //public struct DocuSignEvent
        //{
        //    public string id { get; set; }
        //    public string @event { get; set; }
        //}
    }
}
