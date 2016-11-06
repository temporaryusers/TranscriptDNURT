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
    public class SubjectRepository : ISubjectRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Subject> Subjects
        {
            get
            {
                return context.Subjects;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        public void Create(Subject subject)
        {
            context.Subjects.Add(subject);

            Save();
        }

        public void Edit(Subject subject)
        {
            context.Entry(subject).State = EntityState.Modified;

            Save();
        }

        public void Delete(int id)
        {
            Subject subject = context.Subjects.Find(id);

            context.Subjects.Remove(subject);

            Save();
        }
    }
}
