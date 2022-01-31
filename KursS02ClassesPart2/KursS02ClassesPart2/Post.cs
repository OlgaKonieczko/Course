using System;
using System.Collections.Generic;
using System.Text;

namespace KursS02ClassesPart2
{
    class Post
    {
        DateTime postDate;
        private int _voteValue = 0;
        private List<string> _wholePost = new List<string>();

        public int VoteValue { get => _voteValue; set => _voteValue = value; }
        public List<string> WholePost { get => _wholePost; set => _wholePost = value; }

        public  void New(string postTitle, string newPost)
        {
            postDate = DateTime.Now;
            _wholePost.Add(postDate.ToString("dd.MM.yyyy hh: mm"));
            _wholePost.Add(postTitle);
            _wholePost.Add(newPost);
        }

        public int voteAdd()
        {
            _voteValue += 1 ;
            return _voteValue;
            
        }

        public int voteMinus()

        {
            _voteValue -= 1 ;
            return _voteValue;   
        }

}


}
