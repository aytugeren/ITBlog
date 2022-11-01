using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.Entities.Concrete;
using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostFolder;
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
                cfg.CreateMap<PostDTO, Post>().ReverseMap();
                cfg.CreateMap<CategoryDTO, Category>().ReverseMap();
                cfg.CreateMap<PictureDTO, Picture>().ReverseMap();
            });

            return mapperConfiguration;
        }
    }
}
