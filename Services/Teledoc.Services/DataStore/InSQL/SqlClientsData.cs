using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Teledoc.DAL.Context;
using Teledoc.Domain.Entities.Clients;
using Teledoc.Domain.Entities.Founders;
using Teledoc.Interfaces.Services;

namespace Teledoc.Services.DataStore.InSQL
{
    public class SqlClientsData : IClientsData
    {
        private readonly TeledocDB _db;
        public SqlClientsData(TeledocDB db) => _db = db;

        public IEnumerable<Client> GetClients() => _db.Clients.Include(p=>p.Founder);
        public IEnumerable<Founder> GetFounders() => _db.Founders;

        public Client GetClientById(int id) => _db.Clients
            .Include(p=>p.Founder)
            .FirstOrDefault(e => e.Id == id);

        public int Add(Client Client)
        {
            if (Client is null) throw new ArgumentNullException(nameof(Client));
            if (Client.Id != 0) throw new InvalidOperationException("Для присвоения порядкового номера предусмотрен первичный ключ");

            _db.Clients.Add(Client);
            return Client.Id;
        }
        public void Edit(Client Client)
        {
            if (Client is null) throw new ArgumentNullException(nameof(Client));

            _db.Update(Client);
        }

        public bool Delete(int id)
        {
            var client = _db.Clients.FirstOrDefault(e => e.Id == id);
            if (client is null) return false;

            _db.Remove(client);
            return true;
        }

        public void SaveChanges() => _db.SaveChanges();
    }
}
