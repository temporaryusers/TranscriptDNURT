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
    public class TranscriptRepository : ITranscriptRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Transcript> Transcripts
        {
            get
            {
                return context.Transcripts;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Create(Transcript transcript)
        {
            context.Transcripts.Add(transcript);

            Save();
        }

        public void Edit(Transcript transcript)
        {
            context.Entry(transcript).State = EntityState.Modified;

            Save();
        }

        public void Delete(int id)
        {
            Transcript transcript = context.Transcripts.Find(id);

            context.Transcripts.Remove(transcript);

            Save();
        }
    }
}
