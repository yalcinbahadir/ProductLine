using Microsoft.AspNetCore.Components;
using ProductLine.Entities;
using ProductLine.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Pages
{
    public class ConfirmDeleteBase : ComponentBase
    {
        public Product Product { get; set; } = new Product();
        protected string photoPath;
        [Parameter]
        public string Id { get; set; }
        [Inject]
        public IUnitOfWork UnitOfWork { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected override void OnParametersSet()
        {
            if (int.TryParse(Id, out int id))
            {
                Product = UnitOfWork.ProductRepo.GetById(id);
                photoPath = Product?.Photos?.ToList()[0].Url;
            }
           
          
        }

        protected void ChangeMainPhoto(string photoUrl)
        {
            photoPath = photoUrl;
        }

        protected void  CancelDelete()
        {
            NavigationManager.NavigateTo("/productlist");
        }
        protected void ConfirmDelete()
        {
            var isDeleted = UnitOfWork.ProductRepo.Delete(Product.Id);
            if (isDeleted)
            {
                StateHasChanged();
            }
            NavigationManager.NavigateTo("/productlist", true);
        }
    }
}
