﻿using System;
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
    public class SpecialityRepository : ISpecialityRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Speciality> Specialities
        {
            get
            {
                return context.Specialities;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        public void Create(Speciality speciality)
        {
            context.Specialities.Add(speciality);

            Save();
        }

        public void Edit(Speciality speciality)
        {
            context.Entry(speciality).State = EntityState.Modified;

            Save();
        }

        public void Delete(int id)
        {
            Speciality speciality = context.Specialities.Find(id);

            context.Specialities.Remove(speciality);

            Save();
        }
    }
}
