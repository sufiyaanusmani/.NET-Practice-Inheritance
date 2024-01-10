using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Post
    {
        private static int currentPostID;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Sufiyaan Usmani";
        }

        public Post(string title, bool isPublic, string sendByUsername)
        {
            ID = GetNextID();
            Title = title;
            IsPublic = isPublic;
            SendByUsername = sendByUsername;
        }

        protected int GetNextID()
        {
            return ++currentPostID;
        }

        public void Update(string Title, bool IsPublic)
        {
            this.Title = Title;
            this.IsPublic = IsPublic;
        }

        public override string ToString()
        {
            return $"{this.ID} - {this.Title} - {this.SendByUsername}";
        }
    }
}
