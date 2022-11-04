using ITBlog.Business.DTO;
using ITBlog.Business.DTO.ViewDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.PostServiceFolder
{
    public interface IPostService
    {
        List<IndexViewDTOS> GetPostsByPlace(Guid placeId);
    }
}
