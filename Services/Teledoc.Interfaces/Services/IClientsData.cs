using System.Collections.Generic;
using Teledoc.Domain.Entities.Clients;

namespace Teledoc.Interfaces.Services
{
    public interface IClientsData
    {
        IEnumerable<Client> Get();

        Client GetByID(int id);

        int Add(Client Client);

        void Edit(Client Client);

        bool Delete(int id);

        void SaveChanges();
    }
}
