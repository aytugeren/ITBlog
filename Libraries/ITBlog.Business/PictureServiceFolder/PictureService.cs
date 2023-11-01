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

        public PictureDTO GetPictureDetailById(Guid id)
        {
            if (id != Guid.Empty)
            {
                var picture = _pictureRepository.GetById(id);
                if (picture != null)
                {
                    return _mapper.Map<PictureDTO>(picture);
                }
            }

            return new PictureDTO();
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

        public List<PictureDTO> GetPicturesForAdmin()
        {
            var pictureList = _pictureRepository.Query(null, "Posts|Posts.Post|Authors|Authors.Author");

            return _mapper.Map<List<PictureDTO>>(pictureList);
        }

        public bool RemovePicture(Guid id)
        {
            var result = _pictureRepository.GetById(id);
            if (result != null && result.Id != Guid.Empty)
            {
                result.IsActive = false;
                result.IsDeleted = true;
                result.UpdatedDateTime = DateTime.Now;

                _pictureRepository.Update(result);
                return true;
            }

            return false;
        }

        public bool SubmitPicture(PictureDTO picture, bool isUpdate)
        {
            if (picture != null)
            {
                var pictureEntity = new Picture()
                {
                    Id = isUpdate ? picture.Id : Guid.NewGuid(),
                    PictureTitle = picture.PictureTitle,
                    PicturePlace = picture.PicturePlace,
                    PictureUrl = picture.PictureUrl,
                    PictureAltName = picture.PictureAltName,
                    PictureContent = picture.PictureContent,
                    PictureExtension = picture.PictureExtension,
                    PictureFilePath = picture.PictureFilePath,
                    PictureIsDefault = picture.PictureIsDefault,
                    PictureName = picture.PictureName,
                    IsActive = picture.IsActive,
                    IsDeleted = picture.IsDeleted,
                    CreatedDateTime = isUpdate ? picture.CreatedDateTime : DateTime.Now,
                    UpdatedDateTime = isUpdate ? DateTime.Now : null
                };

                if (isUpdate)
                {
                    _pictureRepository.Update(pictureEntity);
                }
                else
                {
                    _pictureRepository.Insert(pictureEntity);
                }

                return true;
            }

            return false;
        }
    }
}
