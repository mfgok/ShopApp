﻿using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Concrete.Memory
{
    public class MemoryProductDal : IProductDal
    {
        public void Create(Product _entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product _entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            var products = new List<Product>()
            {
                new Product(){Id=1,Name="Nohut",Price=12,ImageUrl="1.jpg"},
                new Product(){Id=2,Name="Fasülye",Price=15,ImageUrl="2.jpg"},
                new Product(){Id=3,Name="Barbunya",Price=10,ImageUrl="3.jpg"}
            };
            return products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductDetails(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product _entity)
        {
            throw new NotImplementedException();
        }
    }
}
