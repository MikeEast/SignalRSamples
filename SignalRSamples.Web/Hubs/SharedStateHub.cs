using System;
using System.Collections.Generic;
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
        
        public Movie Movie
        {
            get { return movie; }
            set { movie = value; }
        }

        public void Update()
        {
            var s = Clients.Caller.title;
            Movie = Clients.Caller.movie;
            Clients.Others.update();
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