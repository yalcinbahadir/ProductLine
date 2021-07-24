using Microsoft.AspNetCore.Components;
using ProductLine.Entities;
using ProductLine.Models;
using ProductLine.Repositories;
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
        public IUnitOfWork UnitOfWork { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public bool ShowUploadModule { get; set; }
        public string NewPhotoPath { get; set; }
        protected ElementReference ProductReferenceInput;
        protected override void OnInitialized()
        {          
            Categories = UnitOfWork.CategoryRepo.GetAll().ToList();
            
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await ProductReferenceInput.FocusAsync();          
            //return base.OnInitializedAsync();
        }

        protected void HandelValidSubmit()
        {
            var product=MapModelToProduct(Model);
            if (product != null)
            {
                UnitOfWork.ProductRepo.Add(product);
                NavigationManager.NavigateTo("/productlist");
            }

        }

        protected void GetPhotoPath(string newPath)
        {
            NewPhotoPath = newPath;
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
            product.Photos = new List<Photo>() { new Photo() { Url= NewPhotoPath==null? "part.jpg": NewPhotoPath } };
            return product;
        }
    }
}
