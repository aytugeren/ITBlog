using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.DTO
{
    public class AuthorDTO : BaseDTO
    {
        public AuthorDTO()
        {
            this.Posts = new List<PostDTO>();
        }

        public string? AuthorName { get; set; }

        public string? AuthorSecondName { get; set; }

        public string? AuthorLastName { get; set; }

        public DateTime AuthorBirthday { get; set; }

        public int PostCount { get; set; }

        public string? AuthorRole { get; set; }

        public virtual ICollection<PostDTO> Posts { get; set; }
    }
}
