using ShopApp.Business.Abstract;
using ShopApp.Entities;
using ShopApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.DataAccess.Abstract;
using System.Linq;

namespace ShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Create(Product _entity)
        {
            _productDal.Create(_entity);
        }

        public void Delete(Product _entity)
        {
            _productDal.Delete(_entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> GetPopularProducts()
        {
            return _productDal.GetAll(p => p.Price > 2000);
        }

        public Product GetProductDetails(int id)
        {
            return _productDal.GetProductDetails(id);
        }

        public void Update(Product _entity)
        {
            _productDal.Update(_entity);
        }
    }
}
