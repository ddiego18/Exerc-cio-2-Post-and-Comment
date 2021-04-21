using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_2_Post_and_Comment.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment()
        {

        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
