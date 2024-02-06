using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryExercise1
{
    public class Content
    {
        public int ViewCount { get; private set; }

        public string Title { get; set; }

        public string ShowName { get; set; }

        public string SeasonName { get; set; }

        public int EpisodeNumber { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Duration Duration { get; set; }

        public AgeRating AgeRating { get; set; }

        public List<string> Directors { get; private set; }

        public List<string> NotableActors { get; private set; }

        public List<Genre> Genres { get; private set; }

        public Content()
        {
            this.ViewCount = 0;
            this.Title = "";
            this.ShowName = "";
            this.SeasonName = "";
            this.EpisodeNumber = 1;
            this.Description = "";
            this.ReleaseDate = DateTime.Now;
            this.Duration = null;
            this.Directors = new List<string>();
            this.NotableActors = new List<string>();
            this.Genres = new List<Genre>();
        }

        public void IncrementView()
        {
            this.ViewCount += 1;
        }
    }
}
