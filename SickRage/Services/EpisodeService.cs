﻿using SickRage.Model;
using System.Net.Http;

namespace SickRage.Services
{
    public class EpisodeService
    {
        private readonly HttpClient _client;

        public EpisodeService()
        {
            _client = new HttpClient();
        }

        public Episode GetEpisode(int showId, int season, int episode)
        {
            const string command = "?cmd=episode&indexerid={0}&season={1}&episode={2}";

            return _client.Get<Episode>(command, showId, season, episode);
        }
    }
}