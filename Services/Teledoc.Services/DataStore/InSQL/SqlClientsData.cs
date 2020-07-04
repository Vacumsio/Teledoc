using System;
using System.Collections.Generic;
using System.Linq;
using Teledoc.DAL.Context;
using Teledoc.Domain.Entities.Clients;
using Teledoc.Interfaces.Services;

namespace Teledoc.Services.DataStore.InSQL
{
    public class SqlClientsData : IClientsData
    {
        private readonly TeledocDB _db;
        public SqlClientsData(TeledocDB db) => _db = db;

        public IEnumerable<Client> Get() => _db.Clients;

        public Client GetByID(int id) => _db.Clients.FirstOrDefault(e => e.Id == id);

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
