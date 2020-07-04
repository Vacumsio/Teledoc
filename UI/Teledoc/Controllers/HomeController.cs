using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Teledoc.Domain.ViewModels;
using Teledoc.Interfaces.Services;

namespace Teledoc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClientsData _ClientsData;

        public HomeController(IClientsData ClientsData) => _ClientsData = ClientsData;

        public IActionResult Index() => View(_ClientsData.Get());

        public IActionResult ClientsDetails(int id) 
        {
            var client = _ClientsData.GetByID(id);
            if (client is null)
            {
                return NotFound();
            }

            return View(client);
        }

        public IActionResult Edit(int? id)
        {
            if (id is null) return View(new ClientViewModel());
            if (id < 0) return BadRequest();

            var client = _ClientsData.GetByID((int)id);
            if (client is null) return NotFound();

            return View(client);
        }
    }
}
