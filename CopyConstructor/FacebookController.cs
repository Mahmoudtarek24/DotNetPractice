using CopyConstructor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
	public class FacebookController
	{
		public Post EditPost(Post originalPost ,string newContent)
		{
			Console.WriteLine("--- Edit Post Feature ---");
			var backupPost = new Post(originalPost);

			originalPost.Content = newContent;

			Console.WriteLine("After Edit:");
			Console.WriteLine($"Original: {originalPost.Content}");
			Console.WriteLine($"Backup: {backupPost.Content}");
			
			return originalPost;
		}
		public Post SharePost(Post originalPost, User sharingUser, string shareComment)
		{
			Console.WriteLine("--- Share Post Feature ---"); 
			var sharedPost = new Post(originalPost);

			sharedPost.AddComment($"{sharingUser.Name}: {shareComment}");

			foreach (var comment in sharedPost.Comments)
				Console.WriteLine($"  - {comment}");


			return sharedPost;
		}
		public void DemoScenarios()
		{
			Console.WriteLine("== Facebook Copy Constructor Demo ==");

			// Create user
			var ahmed = new User(1, "Ahmed Ali", "ahmed@email.com");
			ahmed.FollowersCount = 150;

			// Create Post
			var originalPost = new Post(1, "How are you today", ahmed);
			originalPost.Likes = 25;
			originalPost.AddComment(" Good And you ");
			originalPost.AddComment("Hi Ahmed");


			Console.WriteLine("Original Post: ");
			Console.WriteLine(originalPost);
			Console.WriteLine();

		

			//  Edit Post
			var backup = EditPost(originalPost, "the old post after update");

			// Feature 2: Share Post
			var sara = new User(2, "Sara Mohamed", "sara@email.com");
			var sharedPost = SharePost(originalPost, sara, "I share this post with my friend");
		}
	}
}
