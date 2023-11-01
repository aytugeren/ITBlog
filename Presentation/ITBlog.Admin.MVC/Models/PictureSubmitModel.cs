namespace ITBlog.Admin.MVC.Models
{
    public class PictureSubmitModel
    {
        public Guid PictureId { get; set; }
        public string? PictureName { get; set; }
        public string? PictureTitle { get; set; }
        public string? PicturePlace { get; set; }
        public string? PictureUrl { get; set; }
        public string? PictureAltName { get; set; }
        public string? PictureFilePath { get; set; }
        public string? PictureExtension { get; set; }
        public string? PictureContent { get; set; }
        public bool PictureIsDefault { get; set; }
        public bool PictureIsActive { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
