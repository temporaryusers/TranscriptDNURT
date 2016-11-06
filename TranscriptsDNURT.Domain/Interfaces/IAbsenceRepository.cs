using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranscriptsDNURT.Domain.Entities;

namespace TranscriptsDNURT.Domain.Interfaces
{
    public interface IAbsenceRepository
    {
        IEnumerable<Absence> Absences { get; }

        void Save();

        void Create(Absence absence);

        void Edit(Absence absence);

        void Delete(int id);
    }
}
