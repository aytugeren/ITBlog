using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.UserServiceFolder
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public UserService(IRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UserDTO GetUserByEmail(string email)
        {
            var user = _userRepository.Query(x => x.Email == email, string.Empty);

            if (user.Count > 0)
            {
                return _mapper.Map<UserDTO>(user.FirstOrDefault());
            }

            return default(UserDTO);
        }

        public UserDTO GetUserByUserName(string userName)
        {
            var user = _userRepository.Query(x => x.UserName == userName, string.Empty);

            if (user.Count > 0)
            {
                return _mapper.Map<UserDTO>(user.FirstOrDefault());
            }

            return default(UserDTO);
        }

        public bool InserToUser(UserDTO model)
        {
            try
            {
                model.Id = Guid.NewGuid();
                _userRepository.Insert(_mapper.Map<User>(model));
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
