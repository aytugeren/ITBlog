using ITBlog.Business.DTO;

namespace ITBlog.Business.AuthorServiceFolder
{
    public interface IAuthorService
    {
        bool CheckAuthor(AuthorDTO author, string saltPassword);

        AuthorDTO GetAuthorById(Guid id);

        AuthorDTO GetAuthorByName(string name);

        AuthorDTO GetAuthorByEmail(string email);

        bool InsertAuthor(AuthorDTO author);

    }
}
