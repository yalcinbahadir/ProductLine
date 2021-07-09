using Microsoft.AspNetCore.Components;
using ProductLine.Entities;
using ProductLine.Models;
using ProductLine.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Pages
{
    public class ProductCreateBase : ComponentBase
    {
        public ProductCreateModel Model { get; set; } = new ProductCreateModel();
        public List<Category> Categories { get; set; } = new List<Category>();
        [Inject]
        public ICategoryRepository CategoryRepository { get; set; }
        [Inject]
        public IProductRepository ProductRepository { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected override void OnInitialized()
        {
            Categories = CategoryRepository.GetAll().ToList();
            
        }

        protected void HandelValidSubmit()
        {
            var product=MapModelToProduct(Model);
            if (product != null)
            {
                ProductRepository.Add(product);
                NavigationManager.NavigateTo("/productlist");
            }

        }

        private Product MapModelToProduct(ProductCreateModel model)
        {
            var product = new Product();
            product.RefNumber = model.RefNumber;
            product.Name = model.Name;
            product.CretaedAt = model.CretaedAt;
            product.Description = model.Description;
            product.AssemblyNr = model.AssemblyNr;
            product.CategoryId = int.TryParse(model.CategoryId, out int id) ? id : 1;
            product.IsControlled = model.IsControlled;
            product.Target = model.Target.ToString();
            product.Land = model.Land;
            product.Market = model.Market;
            product.Photos = new List<Photo>() { new Photo() { Url="part.jpg" } };
            return product;
        }
    }
}
