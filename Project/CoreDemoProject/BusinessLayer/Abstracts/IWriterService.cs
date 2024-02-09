using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
	public interface IWriterService:IGenericService<Writer>
	{
		ICollection<Writer> GetWriterById(int id);
	}
}
