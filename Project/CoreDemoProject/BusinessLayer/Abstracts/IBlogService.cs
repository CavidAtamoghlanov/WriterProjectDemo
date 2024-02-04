using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
	public interface IBlogService
	{
		ICollection<Blog> AllCategory();
		void AddBlog(Blog blog);
		void UpdateBlog(Blog blog);
		void DeleteBlog(Blog blog);
		Blog GetById(int id);

		ICollection<Blog> GetAllWithCategory();
		ICollection<Blog> GetBlogListByWriter(int id);
		
	}
}
