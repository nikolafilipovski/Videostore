using System;
using System.Collections.Generic;
using System.Text;
using VirtualVideostore.Repository.Interfaces;
using VirtualVideostore.Service.Interfaces;

namespace VirtualVideostore.Service
{
    public class WatchlistService : IWatchlistService
    {
        private readonly IWatchlistRepository _watchlistRepository;

        public WatchlistService(IWatchlistRepository watchlistRepository)
        {
            _watchlistRepository = watchlistRepository;
        }
    }
}
