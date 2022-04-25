using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    public class Post
    {
        private DateTime _dateCreated = DateTime.Now;
        private int _voteStatus = 0;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public String Title { get; set; }
        public String Description { get; set; }

        public void UpVote()
        {
            _voteStatus++;
        }
        
        public void DownVote()
        {
            _voteStatus--;
        }

        public int VoteStatus
        {
            get { return _voteStatus; }
        }

        public DateTime GetDateCreated()
        {
            return _dateCreated;
        }

    }
}
