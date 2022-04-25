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
        private int _voteStatus;

        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime GetDateCreated()
        {
            return _dateCreated;
        }

        public void UpVote()
        {
            _voteStatus++;
        }
        
        public void DownVote()
        {
            _voteStatus--;
        }

    }
}
