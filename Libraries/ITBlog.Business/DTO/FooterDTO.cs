﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.DTO
{
	public class FooterDTO
	{
		public List<CategoryDTO> Categories { get; set; }

		public PictureDTO FooterLogo { get; set; }

		public List<PostDTO> Posts { get; set; }
	}
}
