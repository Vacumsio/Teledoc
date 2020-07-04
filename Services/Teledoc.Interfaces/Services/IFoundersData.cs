using System.Collections.Generic;
using Teledoc.Domain.Entities.Founders;

namespace Teledoc.Interfaces.Services
{
    public interface IFoundersData
    {
        IEnumerable<Founder> Get();

        Founder GetByID(int id);

        int Add(Founder Founder);

        void Edit(Founder Founder);

        bool Delete(int id);

        void SaveChanges();
    }
}
