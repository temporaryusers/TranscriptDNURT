using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TranscriptsDNURT.Domain.Entities;

namespace TranscriptsDNURT.Domain.Interfaces
{
    public interface ITranscriptRepository
    {
        IEnumerable<Transcript> Transcripts { get; }

        void Save();

        void Create(Transcript transcript);

        void Edit(Transcript transcript);

        void Delete(int id);
    }
}
