using ETrad.Date.Models.Entities;
using ETrade.Business.Concrete;
using ETrade.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dal.Concrete
{
    public class ProductDAL : GenericRepository<Product, ETradeContext>
    {
    }
}
