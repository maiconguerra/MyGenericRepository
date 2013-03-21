using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public interface IRepository<T>
		where T : Entity.IEntity
	{
		void Save(T entity);
		T Get(Expression<T> selector);
		void Delete(T entity);
	}
}
