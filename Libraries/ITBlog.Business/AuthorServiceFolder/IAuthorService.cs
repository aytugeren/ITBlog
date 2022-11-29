using ITBlog.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.AuthorServiceFolder
{
    public interface IAuthorService
    {
        AuthorDTO GetAuthorById(Guid id);

        AuthorDTO GetAuthorByName(string name);
    }
}
