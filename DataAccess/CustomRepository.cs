using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class CustomRepository : GenericRepository<Business.Entity.Order, MyDataContext>, Business.IOrderRepository
	{
		public List<Business.Entity.Order> GetByProduct(Business.Entity.Product product)
		{
			var context = this.DataContext;
			return null;
		}
	}
}
