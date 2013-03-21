using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public interface IRepositoryFactory
	{
		IRepository<T> GetGenericRepository<T>()
		where T : Entity.IEntity;

		IOrderRepository GetOrderRepository();
	}
}
