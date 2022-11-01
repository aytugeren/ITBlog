using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.DTO
{
    public class CategoryDTO : BaseDTO
    {
        public CategoryDTO()
        {
            this.Posts = new HashSet<PostDTO>();
        }

        public string? CategoryName { get; set; }

        public bool IsCategoryMain { get; set; }

        public Guid? ParentCategoryId { get; set; }

        public string? CategoryPlace { get; set; }

        public string? CategoryUrl { get; set; }

        public string? CategorySeoName { get; set; }


        public virtual ICollection<PostDTO> Posts { get; set; }
    }
}
