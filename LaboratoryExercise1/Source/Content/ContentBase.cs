using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryExercise1.Source
{
    public class ContentBase
    {
        public List<Content> Content
        {
            get
            {
                return this.content.ToList<Content>();
            }
            private set { }
        }

        public List<User> PaidUsers
        {
            get
            {
                return this.paidUsers.ToList<User>();
            }
            private set { }
        }

        private List<User> paidUsers;

        private List<Content> content;

        public ContentBase()
        {
            this.content = new List<Content>();
            this.paidUsers = new List<User>();
        }

        public void AddContent(Content content)
        {
            this.content.Add(content);
        }

        public void RemoveContent(int id)
        {
            if (this.content.Count <= 0)
            {
                Console.WriteLine("Content does not exist!");
                return;
            }

            this.content.RemoveAt(id);
        }

        public void AddPaidUser(User user)
        {
            if (this.paidUsers.Contains(user))
            {
                Console.WriteLine("User already exists!");
                return;
            }

            this.paidUsers.Add(user);
        }

        public void RemovePaidUser(User user)
        {
            if (!this.paidUsers.Contains(user))
            {
                Console.WriteLine("User does not exist!");
                return;
            }

            this.paidUsers.Remove(user);
        }

        public void ViewContent(User user, int contentId)
        {
            if (user == null || !this.paidUsers.Contains(user) || contentId < 0 || contentId >= this.content.Count)
            {
                Console.WriteLine("User may not have paid subscription or Content does not exist!");
                return;
            }

            this.content[contentId].IncrementView();
        }
    }
}
