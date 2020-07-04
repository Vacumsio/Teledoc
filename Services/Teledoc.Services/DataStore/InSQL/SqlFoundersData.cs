using System;
using System.Collections.Generic;
using System.Linq;
using Teledoc.DAL.Context;
using Teledoc.Domain.Entities.Founders;
using Teledoc.Interfaces.Services;

namespace Teledoc.Services.DataStore.InSQL
{
    public class SqlFoundersData : IFoundersData
    {
        private readonly TeledocDB _db;
        public SqlFoundersData(TeledocDB db) => _db = db;

        public IEnumerable<Founder> Get() => _db.Founders;

        public Founder GetByID(int id) => _db.Founders.FirstOrDefault(e => e.Id == id);

        public int Add(Founder Founder)
        {
            if (Founder is null) throw new ArgumentNullException(nameof(Founder));
            if (Founder.Id != 0) throw new InvalidOperationException("Для присвоения порядкового номера предусмотрен первичный ключ");

            _db.Add(Founder);
            return Founder.Id;
        }
        public void Edit(Founder Founder)
        {
            if (Founder is null) throw new ArgumentNullException(nameof(Founder));

            _db.Update(Founder);
        }

        public bool Delete(int id)
        {
            var founder = _db.Founders.FirstOrDefault(e => e.Id == id);
            if (founder is null) return false;

            _db.Remove(founder);
            return true;
        }

        public void SaveChanges() => _db.SaveChanges();
    }
}
