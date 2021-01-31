using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
       

        public InMemoryProductDal()
        {
            _products = new List<Product> { 
            
                new Product{Id=1,ColorId="mavi",BrandId="1",DailyPrice=100,ModelYear=2022,Description="Mercedes" },
                new Product{Id=2,ColorId="mavi",BrandId="2",DailyPrice=101,ModelYear=2023,Description="BMW" },
                new Product{Id=3,ColorId="mavi",BrandId="3",DailyPrice=102,ModelYear=2024,Description="Tesla" },
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = productToDelete = _products.SingleOrDefault(p => product.Id == product.Id);

            _products.Remove(productToDelete);
            
            
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate= _products.SingleOrDefault(p => product.Id == product.Id);
            productToUpdate.Id = product.Id;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
            productToUpdate.ModelYear = product.ModelYear;
        }
        public List<Product> GetByCategory(int categoryId)
        {
            return _products.Where(p => p.Id ==categoryId).ToList();
        }
    }
}






