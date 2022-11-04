namespace ITBlog.Business.DTO.MappingDTOs
{
    public class CategoryPlaceDTO : BaseDTO
    {
        public Guid PlaceId { get; set; }

        public Guid CategoryId { get; set; }

        public PlaceDTO Place { get; set; }

        public CategoryDTO Category { get; set; }
    }
}
