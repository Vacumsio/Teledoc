using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teledoc.Domain.Entities.Clients;
using Teledoc.Domain.ViewModels;

namespace Teledoc.Services.Mapping
{
    public static class ClientMapper
    {
        public static ClientViewModel ToView(this Client cl) => new ClientViewModel
        {
            Id = cl.Id,
            ClientsINN = cl.ClientsINN,
            Name = cl.Name,
            Organization = cl.Organization,
        };

        public static IEnumerable<ClientViewModel> ToView(this IEnumerable<Client> p) => p.Select(ToView);
        
    }
}
