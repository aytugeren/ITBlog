using ITBlog.Entities.Concrete.CommentFolder;
using ITBlog.Entities.Concrete.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Entities.Concrete.UserFolder
{
	public class User : BaseEntity
	{
		public string UserName { get; set; }

		public string FirstName { get; set; }

		public string SecondName { get; set; }

		public string LastName { get; set; }

		public DateTime Birthday { get; set; }

		public string Email { get; set; }

		public DateTime LastVisitedDate { get; set; }

		public string Password { get; set; }

		public List<Comment> Comments { get; set; }
	}
}
