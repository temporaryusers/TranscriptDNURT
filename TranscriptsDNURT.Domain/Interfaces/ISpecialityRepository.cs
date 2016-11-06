using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranscriptsDNURT.Domain.Entities;

namespace TranscriptsDNURT.Domain.Interfaces
{
    public interface ISpecialityRepository
    {
        IEnumerable<Speciality> Specialities { get; }

        void Save();

        void Create(Speciality speciality);

        void Edit(Speciality speciality);

        void Delete(int id);
    }
}
