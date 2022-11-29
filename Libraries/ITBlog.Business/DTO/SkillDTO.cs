using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Business.DTO
{
    public class SkillDTO : BaseDTO
    {
        public string? SkillName { get; set; }

        public int SkillLearntPercantage { get; set; }

        public virtual ICollection<AuthorDTO> Authors { get; set; }
    }
}
