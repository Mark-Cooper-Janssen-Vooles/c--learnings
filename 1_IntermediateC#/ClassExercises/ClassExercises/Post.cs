using System;

namespace ClassExercises
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private readonly DateTime _created = DateTime.Now;
        private int Votes = 0;

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }

        public void UpVote()
        {
            this.Votes += 1;
        }
        public void DownVote()
        {
            this.Votes -= 1;
        }
        public int GetVotes()
        {
            return this.Votes;
        }
    }
}
