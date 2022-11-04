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
    }
}
