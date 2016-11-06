using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranscriptsDNURT.Domain.Context;
using TranscriptsDNURT.Domain.Entities;
using TranscriptsDNURT.Domain.Interfaces;

namespace TranscriptsDNURT.Domain.Repositories
{
    public class AbsenceRepository : IAbsenceRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Absence> Absences
        {
            get
            {
                return context.Absences;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        public void Create(Absence absence)
        {
            context.Absences.Add(absence);

            Save();
        }

        public void Edit(Absence absence)
        {
            context.Entry(absence).State = EntityState.Modified;

            Save();
        }

        public void Delete(int id)
        {
            Absence absence = context.Absences.Find(id);

            context.Absences.Remove(absence);

            Save();
        }
    }
}
