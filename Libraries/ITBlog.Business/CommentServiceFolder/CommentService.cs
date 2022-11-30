using AutoMapper;
using ITBlog.Business.DTO;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Entities.Concrete.CommentFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.CommentServiceFolder
{
	public class CommentService : ICommentService
	{
		private readonly IRepository<Comment> _commentRepository;
		private readonly IMapper _mapper;

		public CommentService(IRepository<Comment> commentRepository, IMapper mapper)
		{
			_commentRepository = commentRepository;
			_mapper = mapper;
		}

		public List<CommentDTO> GetCommentsByPostId(Guid postId)
		{
			var comments = _commentRepository.Query(x => x.PostId == postId, "Post|User");

			if (comments.Count() > 0)
			{
				return _mapper.Map<List<CommentDTO>>(comments);
			}

			return default(List<CommentDTO>);
		}

		public bool InsertComment(CommentDTO commentDTO)
		{
			if (commentDTO != null)
			{
				if (commentDTO != default(CommentDTO))
				{
					try
					{
						_commentRepository.Insert(_mapper.Map<Comment>(commentDTO));
						return true;
					}
					catch (Exception ex)
					{
						return false;
						throw;
					}
				}
			}

			return false;
		}
	}
}
