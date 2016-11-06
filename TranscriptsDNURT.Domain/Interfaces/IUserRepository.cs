﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranscriptsDNURT.Domain.Entities;

namespace TranscriptsDNURT.Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> Users { get; }

        void Save();

        void Create(User user);

        void Edit(User user);

        void Delete(int id);
    }
}
