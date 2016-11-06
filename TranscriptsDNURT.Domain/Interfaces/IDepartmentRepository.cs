using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranscriptsDNURT.Domain.Entities;

namespace TranscriptsDNURT.Domain.Interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> Departments { get; }

        void Save();

        void Create(Department department);

        void Edit(Department department);

        void Delete(int id);
    }
}
