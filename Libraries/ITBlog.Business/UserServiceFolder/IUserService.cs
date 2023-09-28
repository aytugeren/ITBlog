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

        bool CheckUser(UserDTO userDTO, string saltPassword);

        bool InserToUser(UserDTO model, string saltPassword);

        string SendRememberMail(UserDTO user, string saltPassword);
    }
}
