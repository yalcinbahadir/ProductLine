using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ProductLine.Entities;
using ProductLine.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Pages
{
    public class ProductDetailsBase : ComponentBase
    {
        [Parameter]
        public string Id { get; set; }
        [Inject]
        public IUnitOfWork UnitOfWork { get; set; }
        [Inject]
        public IModalService ModalService { get; set; }
        protected Product Product { get; set; } = new Product();
        protected string photoPath;
        protected EventCallback<string> OnMouseOver { get; set; }
        protected override void OnInitialized()
        {
            if (int.TryParse(Id, out int id))
            {
                Product = UnitOfWork.ProductRepo.GetById(id);
                photoPath = Product.Photos.ToList()[0].Url;
            }          
        }

        protected void ChangeMainPhoto(string photoUrl)
        {
            photoPath = photoUrl;
        }


        protected void ShowProductList()
        {
            ModalService.Show<ProductList>("Product list");
        }
        
    }
}
