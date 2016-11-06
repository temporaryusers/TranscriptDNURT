using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranscriptsDNURT.Domain.Entities;

namespace TranscriptsDNURT.Domain.Interfaces
{
    public interface IGroupRepository
    {
        IEnumerable<GroupStudent> Groups { get; }

        void Save();

        void Create(GroupStudent group);

        void Edit(GroupStudent group);

        void Delete(int id);
    }
}
