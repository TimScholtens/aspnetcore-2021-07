using DemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.APIs
{
    [Route("api/movie")]
    public class MovieApi : ControllerBase
    {
        public IEnumerable<MovieModel> Get()
		{
            var drno = new MovieModel { Title = "James Bond - Dr. No", ReleaseDate = new DateTime(1962, 4, 6, 12, 0, 0), Actors = new List<ActorModel>() };
            var lotr = new MovieModel { Title = "Lord of the Rings", ReleaseDate = new DateTime(2001, 8, 3, 14, 40, 0), Actors = new List<ActorModel>() };
            var fightClub = new MovieModel { Title = "Fight Club", ReleaseDate = new DateTime(1999, 8, 11, 9, 10, 22), Actors = new List<ActorModel>() };

            var sean = new ActorModel { Name = "Sean Connery", Movies = new List<MovieModel>() };
            var elijah = new ActorModel { Name = "Elijah Wood", Movies = new List<MovieModel>() };
            var brad = new ActorModel { Name = "Brad Pitt", Movies = new List<MovieModel>() };

            drno.Actors.Add(sean);
            drno.Actors.Add(brad);
            lotr.Actors.Add(elijah);
            fightClub.Actors.Add(brad);

            sean.Movies.Add(drno);
            elijah.Movies.Add(lotr);
            brad.Movies.Add(drno);
            brad.Movies.Add(fightClub);

            // circulaire referenties
            // self-referencing loops

            return new List<MovieModel> { drno, lotr, fightClub };
        }
    }
}
