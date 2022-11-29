using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.Business.DTO.MappingDTOs;
using ITBlog.Entities.Concrete;
using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.CategoryPlaceFolder;
using ITBlog.Entities.Concrete.CommentFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PlaceFolder;
using ITBlog.Entities.Concrete.PostCategoryFolder;
using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete.PostPictureFolder;
using ITBlog.Entities.Concrete.PostPlaceFolder;
using ITBlog.Entities.Concrete.SocialMediaFolder;
using ITBlog.Entities.Concrete.SubscriberFolder;
using ITBlog.Entities.Concrete.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.AutoMapperFolder
{
    public class ITBlogProfile : Profile
    {
        public static MapperConfiguration Configuration()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AuthorDTO, Author>().ReverseMap();
                cfg.CreateMap<Post, PostDTO>().ReverseMap();
                cfg.CreateMap<CategoryDTO, Category>().ReverseMap();
                cfg.CreateMap<PictureDTO, Picture>().ReverseMap();
                cfg.CreateMap<PlaceDTO, Place>().ReverseMap();
                cfg.CreateMap<PostPlaceDTO, PostPlace>().ReverseMap();
                cfg.CreateMap<PostCategoryDTO, PostCategory>().ReverseMap();
                cfg.CreateMap<PostPictureDTO, PostPicture>().ReverseMap();
                cfg.CreateMap<CategoryPlaceDTO, CategoryPlace>().ReverseMap();
                cfg.CreateMap<SubscriberDTO, Subscriber>().ReverseMap();
                cfg.CreateMap<SocialMediaDTO, SocialMedia>().ReverseMap();
                cfg.CreateMap<UserDTO, User>().ReverseMap();
                cfg.CreateMap<CommentDTO, Comment>().ReverseMap();
                cfg.CreateMap<SkillDTO, Skill>().ReverseMap();
                cfg.CreateMap<ProjectDTO, Project>().ReverseMap();
            });

            return mapperConfiguration;
        }
    }
}
