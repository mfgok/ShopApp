﻿using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EFCore
{
    public class EfCoreProductDal : EfCoreGenericRepository<Product, ShopContext>, IProductDal
    {
        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }
    }
}