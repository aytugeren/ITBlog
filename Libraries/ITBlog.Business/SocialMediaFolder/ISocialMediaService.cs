﻿using ITBlog.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.SocialMediaFolder
{
    public interface ISocialMediaService
    {
        List<SocialMediaDTO> GetSocialMediasByUserName(string userName);
    }
}
