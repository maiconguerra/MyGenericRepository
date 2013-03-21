using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entity;

namespace DataAccess
{
	public class GenericRepository<T, C> : Business.IRepository<T>
		where T : IEntity
		where C : DbContext
	{
		protected C DataContext { get; set; }

		public void Save(T entity)
		{
			throw new NotImplementedException();
		}

		public T Get(System.Linq.Expressions.Expression<T> selector)
		{
			throw new NotImplementedException();
		}

		public void Delete(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
