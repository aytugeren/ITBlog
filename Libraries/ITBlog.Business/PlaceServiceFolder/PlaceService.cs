using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete.PlaceFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.PlaceServiceFolder
{
    public class PlaceService : IPlaceService
    {
        private readonly IRepository<Place> _placeRepository;
        private readonly IMapper _mapper;

        public PlaceService(IRepository<Place> placeRepository, IMapper mapper)
        {
            _placeRepository = placeRepository;
            _mapper = mapper;
        }

        public PlaceDTO GetPlaceByName(string placeName)
        {
            var placeModel = new PlaceDTO();
            if (!string.IsNullOrEmpty(placeName))
            {
                var result = _placeRepository.Query(x => x.PlaceName == placeName, string.Empty).Where(x => x.IsActive && !x.IsDeleted).FirstOrDefault();

                if (result != null)
                {
                    placeModel = _mapper.Map<PlaceDTO>(result);
                }
            }

            return placeModel;
        }

        public List<PlaceDTO> GetPlaceList()
        {
            var placeList = new List<PlaceDTO>();
            var list = _placeRepository.Query(x => x.IsActive && !x.IsDeleted, string.Empty).ToList();

            if (list != null)
            {
                placeList = _mapper.Map<List<PlaceDTO>>(list);
            }

            return placeList;
        }
    }
}
