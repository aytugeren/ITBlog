

using ITBlog.Business.DTO.MappingDTOs;
using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostCategoryFolder;
using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete.PostPictureFolder;
using System.Runtime.CompilerServices;

namespace ITBlog.Business.DTO.ViewDTOs
{
    public class PostListViewDTO
    {
        public Guid Id { get; set; }

        public string? AuthorName { get; set; }

        public string? Title { get; set; }

        public string? ShortText { get; set; }

        public string PublishDate { get; set; }

        public bool? IsActive { get; set; }

        public string MainPicture { get; set; }

        public int CommentCount { get; set; }

        public List<string> CategoryList { get; set; }

    }

}
