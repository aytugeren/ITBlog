using ITBlog.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.PlaceServiceFolder
{
    public interface IPlaceService
    {
        PlaceDTO GetPlaceByName(string placeName);
    }
}
