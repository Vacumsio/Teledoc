using System.Collections.Generic;
using Teledoc.Domain.Entities.Clients;
using Teledoc.Domain.Entities.Founders;

namespace Teledoc.Interfaces.Services
{
    public interface IClientsData
    {
        IEnumerable<Client> GetClients();
        IEnumerable<Founder> GetFounders();
        Client GetClientById(int id);

        int Add(Client Client);

        void Edit(Client Client);

        bool Delete(int id);

        void SaveChanges();
    }
}
