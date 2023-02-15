using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.DTO.ViewDTOs
{
    public class IndexViewDTOS
    {
        public IndexViewDTOS()
        {
            this.Pictures = new List<PictureDTO>();
            this.Category = new List<CategoryDTO>();
        }

        public PostDTO Post { get; set; }

        public List<PictureDTO> Pictures { get; set; }

        public PictureDTO MainPicture { get; set; }

        public List<CategoryDTO> Category { get; set; }

        public string CategoryFlat { get; set; }

        public Guid AuthorId { get; set; }

        public AuthorDTO Author { get; set; }
    }

   
}
