using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Extension.AuthenticationExtensions;
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

        public bool CheckAuthor(AuthorDTO author, string saltPassword)
        {
            bool isAuthorAcceptable = false;

            if (author == null || author == default(AuthorDTO)) 
            {
                return isAuthorAcceptable;
            }

            if (!string.IsNullOrEmpty(author.Email))
            {
                var password = this.HashAlgorithm(saltPassword, author.Password);
                var authorResult = _authorRepository.Query(x => x.Email == author.Email, string.Empty).FirstOrDefault();
                if (authorResult != null)
                {
                    isAuthorAcceptable = password == authorResult.Password;
                }
            }

            return isAuthorAcceptable;
        }

        public AuthorDTO GetAuthorByEmail(string email)
        {
            var model = new AuthorDTO();
            var author = _authorRepository.Query(x => x.Email == email, "Skills").FirstOrDefault();

            if (author != null)
            {
                return _mapper.Map<AuthorDTO>(author);
            }

            return _mapper.Map<AuthorDTO>(model);
        }

        public AuthorDTO GetAuthorById(Guid id)
        {
            var author = _authorRepository.Query(x => x.Id == id, "Skills|Posts|SocialMedias").FirstOrDefault();
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

        public bool InsertAuthor(AuthorDTO author)
        {
            try
            {
                _authorRepository.Insert(_mapper.Map<Author>(author));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private string HashAlgorithm(string saltPassowrd, string password)
        {
            HashingAlgorithm hashing = new HashingAlgorithm(saltPassowrd);
            var resultOfDTO = hashing.GenerateSaltedHash(password);
            return resultOfDTO;
        }
    }
}
