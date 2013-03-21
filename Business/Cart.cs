using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public class Cart
	{
		private readonly IRepositoryFactory factory;
		public Cart(IRepositoryFactory factory)
		{
			this.factory = factory;
		}

		public void SaveOrder(Entity.Order order, List<Entity.Product> products)
		{
			var productRepository = factory.GetGenericRepository<Entity.Product>();
			foreach (var item in products)
			{
				productRepository.Save(item);
			}

			factory.GetOrderRepository().Save(order);
		}
	}
}
