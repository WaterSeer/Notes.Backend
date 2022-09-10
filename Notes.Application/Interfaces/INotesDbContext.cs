﻿using Microsoft.EntityFrameworkCore;
using Notes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Notes.Application.Interfaces
{
    public interface INotesDbContext
    {
        DbSet<Note> Notes { get; set; } 
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
