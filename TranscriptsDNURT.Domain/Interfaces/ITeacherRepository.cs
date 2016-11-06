using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranscriptsDNURT.Domain.Entities;

namespace TranscriptsDNURT.Domain.Interfaces
{
    public interface ITeacherRepository
    {
        IEnumerable<UniversityTeacher> Teachers { get; }

        void Save();

        void Create(UniversityTeacher teacher);

        void Edit(UniversityTeacher teacher);

        void Delete(int id);
    }
}
