using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class DefaultFactory: Business.IRepositoryFactory
	{
		public Business.IRepository<T> GetGenericRepository<T>()
			where T:Business.Entity.IEntity
		{
			return new GenericRepository<T, MyDataContext>();
		}

		public Business.IOrderRepository GetOrderRepository()
		{
			return new CustomRepository();
		}
	}
}
