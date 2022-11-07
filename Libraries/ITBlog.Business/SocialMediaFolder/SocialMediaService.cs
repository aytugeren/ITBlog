using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete.SocialMediaFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.SocialMediaFolder
{
    public class SocialMediaService : ISocialMediaService
    {
        private readonly IRepository<SocialMedia> _socialMediaRepository;
        private readonly IMapper _mapper;

        public SocialMediaService(IRepository<SocialMedia> socialMediaRepository, IMapper mapper)
        {
            _socialMediaRepository = socialMediaRepository;
            _mapper = mapper;
        }

        public List<SocialMediaDTO> GetSocialMediasByUserName(string userName)
        {
            if (!string.IsNullOrEmpty(userName))
            {
                var socialMedias = _socialMediaRepository.Query(null, "Authors");
                if (socialMedias.Any())
                {
                    var filteredSocialMedias = socialMedias.Where(x => x.Authors.Any(y => (y.AuthorName+y.AuthorLastName).ToLower() == userName));

                    if (filteredSocialMedias.Any())
                    {
                        return _mapper.Map<List<SocialMediaDTO>>(filteredSocialMedias.ToList());
                    }
                }
            }

            return default(List<SocialMediaDTO>);
        }
    }
}
