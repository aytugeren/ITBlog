using ITBlog.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.PictureServiceFolder
{
    public interface IPictureService
    {
        List<PictureDTO> GetPicturesByPlaceName(string placeName);

        PictureDTO GetCVByUserName(string userName);

        List<PictureDTO> GetPicturesForAdmin();

        PictureDTO GetPictureDetailById(Guid id);

        bool RemovePicture(Guid id);

        bool SubmitPicture(PictureDTO picture, bool isUpdate);

    }
}
