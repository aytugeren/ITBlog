using ITBlog.Business.DTO.MappingDTOs;
using ITBlog.Entities.Concrete.CategoryPlaceFolder;
using ITBlog.Entities.Concrete.PostPlaceFolder;

namespace ITBlog.Business.DTO
{
    public class PlaceDTO : BaseDTO
    {
        public string PlaceName { get; set; }

        public virtual ICollection<PostPlaceDTO> Posts { get; set; }

        public virtual ICollection<CategoryPlaceDTO> Categories { get; set; }
    }
}
