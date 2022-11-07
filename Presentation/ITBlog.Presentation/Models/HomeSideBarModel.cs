using ITBlog.Business.DTO;
using ITBlog.Business.DTO.ViewDTOs;

namespace ITBlog.Presentation.Models
{
    public class HomeSideBarModel
    {
        public List<IndexViewDTOS> RecentPosts { get; set; }

        public List<PictureDTO> Pictures { get; set; }

        public List<SocialMediaDTO> SocialMedias { get; set; }

        public PictureDTO CVPicture { get; set; }
    }
}
