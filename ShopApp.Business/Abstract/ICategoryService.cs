using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GetAll();

        void Create(Category _entity);
        void Update(Category _entity);
        void Delete(Category _entity);
    }
}
