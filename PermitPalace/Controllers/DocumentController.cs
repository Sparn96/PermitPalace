using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PermitPalace.Services;

namespace PermitPalace.Controllers
{
    /// <summary>
    /// WIP - Will not be DEMO-able for SDHacks
    /// </summary>
    public class DocumentController : Controller
    {
        IDocumentService _DocumentService;
        public DocumentController(IDocumentService ids)
        {
            _DocumentService = ids;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Will upload a new (form enabled) PDF and will parse the names of all the fields and attmpt to match them to existing DB fields.
        /// For the remaining fields, the user can Map the document to existing database fields, OR CREATE a new column in the database.
        /// The Column creation will happen later When adding permits will simply be for updates
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult UploadNewPermitPDF()
        {
            return View();
        }

    }
}
