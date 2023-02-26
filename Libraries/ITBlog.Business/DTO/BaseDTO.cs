namespace ITBlog.Business.DTO
{
    public class BaseDTO
    {
        public Guid Id { get; set; }

        public DateTime CreatedDateTime { get; set; }


        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
    }
}
