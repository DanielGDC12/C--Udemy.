using System;
using StringBuilderExemple.Entities;
using System.Collections.Generic;
using System.Text;

namespace StringBuilderExemple.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public string Title { get; set; }

        public List<Comment> Comment { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime moment, string content, int likes, string title)
        {
            Moment = moment;
            Content = content;
            Likes = likes;
            Title = title;
        }

        public void AddComment(Comment comment)
        {
            Comment.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comment.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes );
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyy HH:mm:ss"));
            sb.AppendLine("Comments:");
            foreach(Comment c in Comment)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();


           

        }


    }
}
