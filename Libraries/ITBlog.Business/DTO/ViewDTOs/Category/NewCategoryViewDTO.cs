using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.DTO.ViewDTOs.Category
{
    public class NewCategoryViewDTO
    {

        public Guid? ParentId { get; set; }

        public string CategoryName { get; set; }

        public string? CategoryUrl { get; set; }

        public string? CategorySeoName { get; set; }

        public bool IsCategoryMain { get; set; }


    }
}
