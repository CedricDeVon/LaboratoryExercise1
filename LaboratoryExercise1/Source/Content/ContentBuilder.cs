using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryExercise1
{
    public class ContentBuilder
    {
        private Content content;

        public ContentBuilder()
        {
            this.content = new Content();
        }

        public ContentBuilder(Content content)
        {
            this.content = content;
        }

        public ContentBuilder Title(string title)
        {
            this.content.Title = title;
            return this;
        }

        public ContentBuilder Description(string description)
        {
            this.content.Description = description;
            return this;
        }

        public ContentBuilder ReleaseDate(DateTime releaseDate)
        {
            this.content.ReleaseDate = releaseDate;
            this.content.ReleaseDate = releaseDate;
            return this;
        }

        public ContentBuilder Duration(Duration duration)
        {
            if (duration == null || duration.Seconds == 0)
            {
                return this;
            }

            this.content.Duration = duration;
            return this;
        }

        public ContentBuilder AgeRating(AgeRating ageRating)
        {
            this.content.AgeRating = ageRating;
            return this;
        }

        public ContentBuilder Genre(Genre genre)
        {
            this.content.Genres.Add(genre);
            return this;
        }

        public ContentBuilder Director(string name)
        {
            this.content.Directors.Add(name);
            return this;
        }

        public ContentBuilder NotableActor(string name)
        {
            this.content.NotableActors.Add(name);
            return this;
        }

        public ContentBuilder ShowName(string name)
        {
            this.content.ShowName = name;
            return this;
        }

        public ContentBuilder SeasonName(string name)
        {
            this.content.SeasonName = name;
            return this;
        }

        public ContentBuilder EpisodeNumber(int number)
        {
            this.content.EpisodeNumber = number;
            return this;
        }

        public Content Build()
        {
            return this.content;
        }

        public void Reset()
        {
            this.content = new Content();
        }
    }
}
