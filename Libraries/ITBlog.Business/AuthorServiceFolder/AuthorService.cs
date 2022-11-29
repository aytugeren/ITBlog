using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete.AuthorFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.AuthorServiceFolder
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IRepository<Author> authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public AuthorDTO GetAuthorById(Guid id)
        {
            var author = _authorRepository.GetById(id);
            if (author != null)
            {
                return _mapper.Map<AuthorDTO>(author);
            }

            return default(AuthorDTO);
        }

        public AuthorDTO GetAuthorByName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var author = _authorRepository.Query(x => x.AuthorName + x.AuthorLastName == name, "Posts|SocialMedias|Projects|Skills").FirstOrDefault();
                return _mapper.Map<AuthorDTO>(author);
            }

            return default(AuthorDTO);
        }
    }
}
