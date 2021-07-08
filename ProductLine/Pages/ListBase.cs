using Microsoft.AspNetCore.Components;
using ProductLine.Entities;
using ProductLine.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Pages
{
    public class ListBase :ComponentBase
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Product> SelectedProducts { get; set; } = new List<Product>();
        [Inject]
        public IUnitOfWork UnitOfWork { get; set; }
        protected override void OnInitialized()
        {
            Products = UnitOfWork.ProductRepo.GetAll().ToList();
            SelectedProducts = Products.Take(4).ToList();

        }
        protected int index = 1;
        protected void Navigate(int number)
        {
            SelectedProducts = Products.Skip(number * 4).Take(4).ToList();
            index = 1;
        }

    }
}
