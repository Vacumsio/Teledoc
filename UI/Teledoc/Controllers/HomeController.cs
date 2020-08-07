using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Teledoc.Domain.Entities.Clients;
using Teledoc.Domain.ViewModels;
using Teledoc.Interfaces.Services;
using Teledoc.Services.Mapping;

namespace Teledoc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClientsData _ClientsData;

        public HomeController(IClientsData ClientsData) => _ClientsData = ClientsData;

        public IActionResult Index() => View(_ClientsData.GetClients());

        public IActionResult ClientsDetails(int id) 
        {
            var client = _ClientsData.GetClientById(id);
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

            var client = _ClientsData.GetClientById((int)id);
            if (client is null) return NotFound();

            return View(new ClientViewModel
            {
                Id = client.Id,
                Name = client.Name,
                ClientsINN = client.ClientsINN,
                Organization = client.Organization,
                UpdateTime = client.UpdateTime,
                AddTime = client.AddTime
            });
        }
        [HttpPost]
        public IActionResult Edit(ClientViewModel Model)
        {
            if (Model is null) throw new ArgumentNullException(nameof(Model));

            if (!ModelState.IsValid) return View(Model);

            var client = new Client
            {
                Id = Model.Id,
                Name = Model.Name,
                ClientsINN = Model.ClientsINN,
                Organization = Model.Organization,
                AddTime = DateTime.Now,
                UpdateTime = DateTime.Now
            };

            if (Model.Id == 0) _ClientsData.Add(client);
            else _ClientsData.Edit(client);

            _ClientsData.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            if (Id <= 0)
            {
                return BadRequest();
            }
            var client = _ClientsData.GetClientById(Id);
            if (client is null)
            {
                return NotFound();
            }
            return View(new ClientViewModel
            {
                Id = client.Id,
                Name = client.Name,
                Organization = client.Organization,
                ClientsINN = client.ClientsINN,
                UpdateTime = client.UpdateTime,
                AddTime = client.AddTime
            });
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int Id)
        {
            _ClientsData.Delete(Id);
            _ClientsData.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
