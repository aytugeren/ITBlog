using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.DTO
{
    public class PostDTO : BaseDTO
    {
        public PostDTO()
        {
            this.Categories = new HashSet<CategoryDTO>();
        }

        public string? Title { get; set; }

        public string? FirstContent { get; set; }

        public string? SecondContent { get; set; }

        public Guid AuthorId { get; set; }

        public virtual ICollection<CategoryDTO> Categories { get; set; }

        public AuthorDTO Author { get; set; }
    }
}
