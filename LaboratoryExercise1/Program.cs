using LaboratoryExercise1.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryExercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContentBuilder contentBuilder = new ContentBuilder();
            Content firstContent = contentBuilder
                .Title("The Matrix")
                .Description("Description...")
                .ReleaseDate(new DateTime())
                .Duration(new Duration(00, 50, 1))
                .AgeRating(AgeRating.Adult)
                .Genre(Genre.ScieneFiction)
                .Genre(Genre.Horror)
                .Director("John Doe")
                .Director("Jane Smith")
                .NotableActor("Simon Doe")
                .NotableActor("Simon Smith")
                .Build();
            contentBuilder.Reset();
            Content secondContent = contentBuilder
                .Title("Pride And Prejudice")
                .Description("Description...")
                .ReleaseDate(new DateTime())
                .Duration(new Duration(00, 25, 3))
                .AgeRating(AgeRating.Adult)
                .Genre(Genre.Romance)
                .Director("Jackson Doe")
                .NotableActor("Sherry Doe")
                .Build();

            User firstUser = new User("Cedric Doe", "cedricdoe@gmail.com");
            User secondUser = new User("Von Doe", "vondoe@gmail.com");
            ContentBase contentBase = new ContentBase();
            contentBase.AddContent(firstContent);
            contentBase.AddContent(secondContent);
            contentBase.AddPaidUser(firstUser);
            contentBase.ViewContent(firstUser, 0);
            contentBase.ViewContent(secondUser, 0);
        }
    }
}
