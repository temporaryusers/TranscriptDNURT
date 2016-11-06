﻿using System.Collections.Generic;
using System.Data.Entity;
using TranscriptsDNURT.Domain.Context;
using TranscriptsDNURT.Domain.Entities;
using TranscriptsDNURT.Domain.Interfaces;

namespace TranscriptsDNURT.Domain.Repositories
{
    public class FacultyRepository : IFacultyRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Faculty> Faculties
        {
            get
            {
                return context.Faculties;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        public void Create(Faculty faculty)
        {
            context.Faculties.Add(faculty);

            Save();
        }

        public void Edit(Faculty faculty)
        {
            context.Entry(faculty).State = EntityState.Modified;

            Save();
        }

        public void Delete(int id)
        {
            Faculty faculty = context.Faculties.Find(id);

            context.Faculties.Remove(faculty);

            Save();
        }
    }
}
