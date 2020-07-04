using System;
using System.Collections.Generic;
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
            Founder = cl.Founder.Surname,
        };

        public static Client FromView(this ClientViewModel cl) => new Client
        {
            Id = cl.Id,
            Name = cl.Name,
            ClientsINN = cl.ClientsINN,
            Organization =cl.Organization,
        };
    }
}
