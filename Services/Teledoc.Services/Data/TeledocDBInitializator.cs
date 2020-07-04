using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;
using Teledoc.DAL.Context;

namespace Teledoc.Services.Data
{
    public class TeledocDBInitializator
    {
        private readonly TeledocDB _db;
        public TeledocDBInitializator(TeledocDB db) => _db = db;

        public void Initialize()
        {
            var db = _db.Database;
            db.Migrate();

            InitializeClient();
            InitializeFounder();
        }

        public void InitializeClient()
        {
            var db = _db.Database;
            if (_db.Clients.Any()) return;

            using (db.BeginTransaction())
            {
                var clients = TestData.Clients.ToList();
                clients.ForEach(e => e.Id = 0);
                _db.Clients.AddRange(clients);

                _db.SaveChanges();
                db.CommitTransaction();
            }
        }

        public void InitializeFounder()
        {
            var db = _db.Database;
            if (_db.Founders.Any()) return;

            using (db.BeginTransaction())
            {
                var founders = TestData.Founders.ToList();
                founders.ForEach(e => e.Id = 0);
                _db.Founders.AddRange(founders);

                _db.SaveChanges();
                db.CommitTransaction();
            }
        }

    }
}
