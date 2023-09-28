using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete.UserFolder;
using ITBlog.Extension.AuthenticationExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

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

        public bool CheckUser(UserDTO userDTO, string saltPassword)
        {
            bool isUserAcceptable = false;
            if (userDTO != null)
            {
                if (userDTO != default(UserDTO))
                {
                    if (!string.IsNullOrEmpty(userDTO.Email))
                    {
                        var user = _userRepository.Query(x => x.Email == userDTO.Email, string.Empty).FirstOrDefault();
                        if (user != null)
                        {
                            isUserAcceptable = user.Password == userDTO.Password;
                        }
                    }
                    else if (!string.IsNullOrEmpty(userDTO.UserName))
                    {
                        var user = _userRepository.Query(x => x.Email == userDTO.UserName, string.Empty).FirstOrDefault();
                        if (user != null)
                        {
                            HashingAlgorithm hashing = new HashingAlgorithm(saltPassword);

                            var resultOfDTO = hashing.GenerateSaltedHash(userDTO.Password);
                            isUserAcceptable = user.Password == resultOfDTO;
                        }
                    }
                }
            }

            return isUserAcceptable;
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

        public bool InserToUser(UserDTO model, string saltPassword)
        {
            try
            {
                model.Id = Guid.NewGuid();
                if (!string.IsNullOrEmpty(model.Password))
                {
                    HashingAlgorithm hashing = new HashingAlgorithm(saltPassword);

                    var result = hashing.GenerateSaltedHash(model.Password);
                    model.Password = result;
                }

                _userRepository.Insert(_mapper.Map<User>(model));
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public string SendRememberMail(UserDTO user, string saltPassword)
        {
            string newPassword = Guid.NewGuid() + user.UserName;

            try
            {
                string from = "aytgeren@gmail.com";
                string password = "72727361AA";
                string subject = "Parola Hatırlatma!";
                string body = $"<h2>Sayın {user.UserName}. Şifreniz : {newPassword}";
                string host = "smtp.gmail.com";
                int port = 465;

                // SMTP sunucusu ayarları
                SmtpClient smtpClient = new SmtpClient(host)
                {
                    Port = port, // SMTP sunucusunun port numarası (Genellikle 587 veya 465 kullanılır)
                    Credentials = new NetworkCredential(host, password) // E-posta hesap bilgileri
                };

                // E-posta gönderici ve alıcı
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(from),
                    Subject = subject,
                    Body = body,
                };

                mailMessage.To.Add(user.Email);

                // E-postayı gönder
                smtpClient.Send(mailMessage);
            }
            catch (Exception)
            {
            }

            HashingAlgorithm hashing = new HashingAlgorithm(saltPassword);

            var result = hashing.GenerateSaltedHash(newPassword);

            bool resultOfProcess = this.ResetPassword(user, result);

            if (resultOfProcess)
            {
                return newPassword;
            }

            return string.Empty;
        }


        private bool ResetPassword(UserDTO user, string? newPassword)
        {
            var userBase = _userRepository.Query(x => x.Email == user.Email, string.Empty).FirstOrDefault();

            if (userBase != null && !string.IsNullOrEmpty(newPassword))
            {
                userBase.Password = newPassword;

                _userRepository.Update(userBase);

                return true;
            }

            return false;

        }
    }
}
