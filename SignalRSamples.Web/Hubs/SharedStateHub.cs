using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRSamples.Web.Hubs
{
    public class SharedStateHub : Hub
    {
        static Movie movie = new Movie
        {
            Title = "Platoon",
            Score = 8.2M,
            Plot = "A young recruit in Vietnam faces a moral crisis when confronted with the horrors of war and the duality of man."
        };
        
        public void Update(Movie m)
        {
            movie = m;
            Clients.Others.update(movie);
        }

        public Movie GetMovie()
        {
            return movie;
        }
        
    }

    [Serializable]
    public class Movie
    {
        public string Title { get; set; }
        public decimal Score { get; set; }
        public string Plot { get; set; }
    }
}