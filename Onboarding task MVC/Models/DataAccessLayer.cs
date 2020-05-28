using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Onboarding_task_MVC.Models;

namespace Onboarding_task_MVC.Models
{
    public class DataAccessLayer
    {
        OnboardingtaskContext db = new OnboardingtaskContext();

        public IEnumerable<Products> GetAllProducts()
        {
            try
            {
                return db.Products.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new product record   
        public int AddProduct(Products product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar product  
        public int UpdateProduct(Products product)
        {
            try
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular product  
        public Products GetProductData(int id)
        {
            try
            {
                Products product = db.Products.Find(id);
                return product;
            }
            catch
            {
                throw;
            }
        }



        //To Delete the record of a particular product  
        public int DeleteProduct(int id)
        {
            try
            {
                Products prd = db.Products.Find(id);
                db.Products.Remove(prd);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Stores> GetAllStores()
        {
            try
            {
                return db.Stores.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new store record   
        public int AddStore(Stores store)
        {
            try
            {
                db.Stores.Add(store);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar store  
        public int UpdateStore(Stores store)
        {
            try
            {
                db.Entry(store).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular store  
        public Stores GetStoreData(int id)
        {
            try
            {
                Stores store = db.Stores.Find(id);
                return store;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular store  
        public int DeleteStore(int id)
        {
            try
            {
                Stores str = db.Stores.Find(id);
                db.Stores.Remove(str);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Customers> GetAllCustomers()
        {
            try
            {
                return db.Customers.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new customer record   
        public int AddCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar customer  
        public int UpdateCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular customer  
        public Customers GetCustomerData(int id)
        {
            try
            {
                Customers customer = db.Customers.Find(id);
                return customer;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular customer  
        public int DeleteCustomer(int id)
        {
            try
            {
                Customers cust = db.Customers.Find(id);
                db.Customers.Remove(cust);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Sales> GetAllSales()
        {
            try
            {
                return db.Sales.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new sale record   
        public int AddSale(Sales sale)
        {
            try
            {
                db.Sales.Add(sale);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar sale  
        public int UpdateSale(Sales sale)
        {
            try
            {
                db.Entry(sale).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular sale  
        public Sales GetSaleData(int id)
        {
            try
            {
                Sales sale = db.Sales.Find(id);
                return sale;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular sale  
        public int DeleteSale(int id)
        {
            try
            {
                Sales sold = db.Sales.Find(id);
                db.Sales.Remove(sold);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Get the list of CustomerName  
        public List<Customers> GetCustomer()
        {
            List<Customers> lstCustomer = new List<Customers>();
            lstCustomer = (from CustomerList in db.Customers select CustomerList).ToList();

            return lstCustomer;
        }

        //To Get the list of StoreName  
        public List<Stores> GetStore()
        {
            List<Stores> lstStore = new List<Stores>();
            lstStore = (from StoreList in db.Stores select StoreList).ToList();

            return lstStore;
        }

        //To Get the list of ProductName  
        public List<Products> GetProduct()
        {
            List<Products> lstProduct = new List<Products>();
            lstProduct = (from ProductList in db.Products select ProductList).ToList();

            return lstProduct;
        }

    }
}