using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete;
using ITBlog.Entities.Concrete.PictureFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.PictureServiceFolder
{
    public class PictureService : IPictureService
    {
        private readonly IRepository<Picture> _pictureRepository;
        private readonly IMapper _mapper;

        public PictureService(IRepository<Picture> pictureRepository, IMapper mapper)
        {
            _pictureRepository = pictureRepository;
            _mapper = mapper;
        }

        public PictureDTO GetCVByUserName(string userName)
        {
            if (!string.IsNullOrEmpty(userName))
            {
                string edditedPictureName = userName + "CV";
                var picture = _pictureRepository.Query(x => x.PictureName == edditedPictureName, string.Empty).FirstOrDefault();

                if (picture != null)
                {
                    return _mapper.Map<PictureDTO>(picture);
                }
            }

            return default(PictureDTO);
        }

        public List<PictureDTO> GetPicturesByPlaceName(string placeName)
        {
            if (!string.IsNullOrEmpty(placeName))
            {
                var result = _pictureRepository.Query(x => x.PicturePlace == placeName, string.Empty);

                if (result.Any())
                {
                    return _mapper.Map<List<PictureDTO>>(result);
                }

            }

            return default(List<PictureDTO>);
        }
    }
}
