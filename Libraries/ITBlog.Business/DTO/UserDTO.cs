namespace ITBlog.Business.DTO
{
	public class UserDTO  : BaseDTO
	{
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public string Email { get; set; }

        public DateTime LastVisitedDate { get; set; }

        public string Password { get; set; }

        public List<CommentDTO> Comments { get; set; }
    }
}
