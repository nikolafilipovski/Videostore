using System;
using System.Collections.Generic;
using System.Text;
using VirtualVideostore.Data;
using VirtualVideostore.Repository.Interfaces;

namespace VirtualVideostore.Repository
{
    public class WatchlistRepository : IWatchlistRepository
    {
        private readonly DataContext _context;

        public WatchlistRepository(DataContext context)
        {
            _context = context;
        }
    }
}
