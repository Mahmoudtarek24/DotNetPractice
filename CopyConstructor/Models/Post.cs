using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor.Models
{
	public class Post
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public User Author { get; set; }
		public int Likes { get; set; }
		public List<string> Comments { get; set; }
		public DateTime CreatedAt { get; set; }

		public Post(int id, string content, User author)
		{
			Id = id;
			Content = content;
			Author = author;
			Likes = 0;
			Comments = new List<string>();
			CreatedAt = DateTime.Now;
		}
		public Post(Post other)
		{
			Id = other.Id;
			Content = other.Content;
			Author = new User(other.Author); 
			Likes = other.Likes;
			CreatedAt = other.CreatedAt;
			Comments= new List<string>(other.Comments);
		}

		public void AddComment(string comment)
		{
			Comments.Add(comment);	
		}
		public override string ToString()
		{
			return $"Post by {Author.Name}: {Content} ({Likes} likes, {Comments.Count} comments)";
		}
	}
}
