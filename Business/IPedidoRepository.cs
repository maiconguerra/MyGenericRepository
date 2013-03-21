using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public interface IOrderRepository : IRepository<Entity.Order>
	{
		List<Entity.Order> GetByProduct(Entity.Product product);
	}
}
