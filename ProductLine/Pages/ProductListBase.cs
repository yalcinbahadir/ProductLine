using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ProductLine.Entities;
using ProductLine.Infrastructure;
using ProductLine.Repositories;
using ProductLine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Pages
{
    public class ProductListBase : ComponentBase
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Product> SelectedProducts { get; set; } = new List<Product>();
        public List<Product> PageProducts { get; set; } = new List<Product>();
        [Inject]
        public PageManager<Product> PageManager { get; set; } 
        [Inject]
        public IUnitOfWork UnitOfWork { get; set; }
        [Inject]
        public IModalService ModalService { get; set; }

        protected bool isOrderedByRefNumber = false;
        protected bool isOrderedByName = false;
        protected bool isOrderedByAssemblyNr = false;
        protected bool isOrderedByCategory = false;
        protected int index = 1;
        protected int ProductsPerPage { get; set; }
        protected int TotalProducts { get; set; }
        protected int TotalPages { get; set; }
        protected override void OnInitialized()
        {
            Products = UnitOfWork.ProductRepo.GetAll().ToList();
            SelectedProducts = Products;
            index = 1;
            SetPage(index);
        }

        protected void SetPage(int index = 1)
        {
            PageManager.Collection = SelectedProducts;
            TotalProducts = (int)PageManager.TotalItems;
            PageProducts = PageManager.PageCollection(index).ToList();
            TotalPages = PageManager.TotalPages;
            ProductsPerPage = PageManager.ItemPerPage;
        }

        #region Order

        protected void OrderByRefNumber()
        {           
            if (!isOrderedByRefNumber)
            {
               
                SelectedProducts = SelectedProducts.OrderBy(p => p.RefNumber).ToList();
                isOrderedByRefNumber = true;
            }
            else
            {
                SelectedProducts = SelectedProducts.OrderByDescending(p => p.RefNumber).ToList();
                isOrderedByRefNumber = false;
            }
            index = 1;
            SetPage(index);
        }        
        protected void OrderByName()
        {
            if (!isOrderedByName)
            {

                SelectedProducts = SelectedProducts.OrderBy(p => p.Name).ToList();
                isOrderedByName = true;
            }
            else
            {
                SelectedProducts = SelectedProducts.OrderByDescending(p => p.Name).ToList();
                isOrderedByName = false;
            }
            index = 1;
            SetPage(index);
        }  
        protected void OrderByAssemblyNr()
        {
            if (!isOrderedByAssemblyNr)
            {

                SelectedProducts = SelectedProducts.OrderBy(p => p.AssemblyNr).ToList();
                isOrderedByAssemblyNr = true;
            }
            else
            {
                SelectedProducts = SelectedProducts.OrderByDescending(p => p.AssemblyNr).ToList();
                isOrderedByAssemblyNr = false;
            }
            index = 1;
            SetPage(index);
        }     
        protected void OrderByCategory()
        {
            if (!isOrderedByCategory)
            {

                SelectedProducts = SelectedProducts.OrderBy(p => p.Category.CategoryName).ToList();
                isOrderedByCategory = true;
            }
            else
            {
                SelectedProducts = SelectedProducts.OrderByDescending(p => p.Category.CategoryName).ToList();
                isOrderedByCategory = false;
            }
            index = 1;
            SetPage(index);
        }
        #endregion
        #region Search
        protected void SearchByRefNumber(ChangeEventArgs e)
       {
            string val = (string)e.Value;
            SelectedProducts=UnitOfWork.ProductRepo.GetByRefNumber(val).ToList();
            index = 1;
            SetPage(index);
        }
        protected void SearchByName(ChangeEventArgs e)
        {
            string val = (string)e.Value;
            SelectedProducts = UnitOfWork.ProductRepo.GetByName(val).ToList();
            index = 1;
            SetPage(index);
        }
        protected void SearchByDescription(ChangeEventArgs e)
        {
            string val = (string)e.Value;
            SelectedProducts = UnitOfWork.ProductRepo.GetByDescription(val).ToList();
            index = 1;
            SetPage(index);
        }
        protected void SearchByAssemblyNr(ChangeEventArgs e)
        {
            string val = (string)e.Value;
            SelectedProducts = UnitOfWork.ProductRepo.GetByAssemblyNumber(val).ToList();
            index = 1;
            SetPage(index);
        }
        protected void SearchByCategory(ChangeEventArgs e)
        {
            string val = (string)e.Value;
            SelectedProducts = UnitOfWork.ProductRepo.GetByCategory(val).ToList();
            index = 1;
            SetPage(index);
        }
        #endregion
        #region Pagination
        protected void NavigateDown()
        {
            index--;
            if (index < 1)
            {
                index = PageManager.TotalPages;
            }
            SetPage(index);
        }
        protected void NavigateUp()
        {
            index++;
            if (index > PageManager.TotalPages)
            {
                index = 1;
            }
            SetPage(index);
        }
        #endregion
        #region ExportAsCSV
        protected void ExportPage()
        {
            CSVExporter.Products = PageProducts.ToList();
            CSVExporter.Export();
        }

        protected void ExportAll()
        {
            CSVExporter.Products = SelectedProducts.ToList();
            CSVExporter.Export();
        }

        #endregion
     

        protected void ShowInModal()
        {
            ModalService.Show<ProductList>("Product list");
        }

        //CreateViaModal
        protected void CreateViaModal()
        {
           // ModalService.Show<ProductCreate>("Product create");
            ModalService.Show<ProductCreate>("Product create",new Blazored.Modal.ModalOptions 
                                                                {   ContentScrollable=true, 
                                                                    DisableBackgroundCancel=true, 
                                                                    HideCloseButton=false, 
                                                                    Position= Blazored.Modal.ModalPosition.TopLeft, 
                                                                    UseCustomLayout= false
                                                                });
        }
    }
}
