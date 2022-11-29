using ITBlog.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.UserServiceFolder
{
    public interface IUserService
    {
        UserDTO GetUserByEmail(string email);

        UserDTO GetUserByUserName(string userName);

        bool CheckUser(UserDTO userDTO);

        bool InserToUser(UserDTO model);
    }
}
