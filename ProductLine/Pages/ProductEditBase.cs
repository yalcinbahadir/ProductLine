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
    public class ProductEditBase : ComponentBase
    {
        public ProductEditModel Model { get; set; } = new ProductEditModel();
        [Parameter]
        public string Id { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        [Inject]
        public IUnitOfWork UnitOfWork { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public bool ShowUploadModule { get; set; }
        public bool ShowDeleteIcon { get; set; } = false;
        public string NewPhotoPath { get; set; }

        protected override void OnInitialized()
        {
            Categories = UnitOfWork.CategoryRepo.GetAll().ToList();

        }
        protected override void OnParametersSet()
        {
            if (int.TryParse(Id, out int id))
            {
                var product = UnitOfWork.ProductRepo.GetById(id);
                Model=MapProductToModel(Model,product);
            }
            else
            {
                NavigationManager.NavigateTo("/productlist");
            }                       
        }

        protected void GetPhotoPath(string newPath)
        {
            NewPhotoPath = newPath;
            //var photo=await UnitOfWork.PhotoRepo.AddAsync(new Photo { ProductId=Model.Id, Url=NewPhotoPath });           
            //Model.Photos.Add(photo);
            //new Photo { ProductId=Model.Id, Url=NewPhotoPath }
            Model.Photos.Add(new Photo { ProductId = Model.Id, Url = NewPhotoPath });
        }

        protected void DeletePhoto(Photo photo)
        {
            //UnitOfWork.PhotoRepo.Delete(photo.Id);
            Model.Photos.Remove(photo);
        }

        protected void HandelValidSubmit()
        {
            var product = UnitOfWork.ProductRepo.GetById(Model.Id);
            MapModelToProduct(Model, product);
            UnitOfWork.ProductRepo.SaveChanges();
            NavigationManager.NavigateTo("/productlist",true);
        }






        private Product MapModelToProduct(ProductEditModel model, Product product)
        {
           
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
            product.Photos = model.Photos;
            return product;
        }

        private ProductEditModel MapProductToModel(ProductEditModel model, Product product)
        {
            model.Id = product.Id;
            model.RefNumber = product.RefNumber;
            model.Name = product.Name;
            model.CretaedAt = product.CretaedAt;
            model.Description = product.Description;
            model.AssemblyNr = product.AssemblyNr;
            model.CategoryId = product.CategoryId.ToString();
            model.IsControlled = product.IsControlled;
            switch (product.Target)
            {
                case "In":
                    model.Target = Target.In;
                    break;
                case "Out":
                    model.Target = Target.Out;
                    break;
                case "Both":
                    model.Target = Target.Both;
                    break;

            }           
            model.Land = product.Land;
            model.Market = product.Market;
            model.Photos = product.Photos.ToList();
            return model;
        }
    }
}
