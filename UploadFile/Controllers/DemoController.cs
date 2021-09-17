using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadFile.Models;
using UploadFile.Entidades;
using UploadFile.Servicos;

namespace UploadFile.Controllers
{
    public class DemoController : Controller
    {
        private readonly DataBaseContext _context;

        public DemoController(DataBaseContext context)
        {
            _context = context;
        }



        public IActionResult Index(IFormFile files)
        {
            if (files == null || files.Length <= 0)
                return View();

            var fileName = Path.GetFileName(files.FileName);
            var fileExtension = Path.GetExtension(fileName);
            var newFileName = string.Concat(fileName, fileExtension);
            var filesdto = new Files()
            {
                Name = newFileName,
                FileType = fileExtension,
                CreatedOn = DateTime.Now
            };

            using (var target = new MemoryStream())
            {
                files.CopyTo(target);
                filesdto.DataFiles = target.ToArray();
            }

            var intercambio = new ConversorNotfis().Converter(files);

            _context.Files.Add(filesdto);
            _context.Intercambios.Add(intercambio);

            _context.SaveChanges();

            return View("ShowFile", new Arquivo(Encoding.UTF8.GetString(filesdto.DataFiles)));
        }
    }
}
