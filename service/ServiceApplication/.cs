using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        Link_to_databaseDataContext db = new Link_to_databaseDataContext();

        //private List<int> CartItems = new List<int>() { 3 };
        //private List<int> WishlistItems = new List<int>() { 1, 2, };

        public bool AddProduct(Product Prod)
        {
            var NProduct = new Product
            {
                Product_ID = Prod.Product_ID,
                Product_Name = Prod.Product_Name,
                Product_Category = Prod.Product_Category,
                Product_Description = Prod.Product_Description,
                Product_Discount = Prod.Product_Discount,
                Product_Price = Prod.Product_Price,
                Product_Supplier = Prod.Product_Supplier
            };
            db.Products.InsertOnSubmit(NProduct);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
                
            }
        }

        // given a product_ID, this function returns 
        // an entire product.
        public Product getProduct(string ID)
        {
            var FoundProduct = (from p in db.Products
                                where p.Product_ID.Equals(ID)
                                select p).FirstOrDefault();

            // creates a product from foundProduct.
            Product pa = new Product
            {
                Product_ID = FoundProduct.Product_ID,
                Product_Name = FoundProduct.Product_Name,
                Product_Price = Convert.ToInt32(FoundProduct.Product_Price),
                Product_Category = FoundProduct.Product_Category,
                Product_Description = FoundProduct.Product_Description,
                Product_Discount = Convert.ToInt32(FoundProduct.Product_Discount),
                Product_Supplier = FoundProduct.Product_Supplier
        };

            // returns the newly created product.
            return pa;
        }


        public bool editProduct(Product Aug, int ID)
        {
            var item = (from i in db.Products
                        where i.Product_ID.Equals(ID)
                        select i).FirstOrDefault();

            item.Product_ID = Aug.Product_ID;
            item.Product_Name = Aug.Product_Name;
            item.Product_Price= Convert.ToInt32(Aug.Product_Price);
            item.Product_Category = Aug.Product_Category;
            item.Product_Description = Aug.Product_Description;
            item.Product_Discount = Convert.ToInt32(Aug.Product_Discount);
            item.Product_Supplier = Aug.Product_Supplier;

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (IndexOutOfRangeException ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        public int FindProductBeingSearched_ID(string ID)
        {
            var FoundProduct = (from p in db.Products
                                where p.Product_ID.Equals(ID)
                                select p).FirstOrDefault();

            if (FoundProduct != null)
            {
                return FoundProduct.Product_ID;
            }
            else
            {
                return 0;
            }
        }

        public bool removeProduct(int ID)
        {
            var Product = (from p in db.Products
                               where p.Product_ID.Equals(ID)
                               select p).FirstOrDefault();


            db.Products.DeleteOnSubmit(Product);

            try
            {
                db.SubmitChanges();
                return true;

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }


        }

        // the function will return true or false
        // depending on whether the given product ID
        // exists in the database
        public bool isNewProduct(string ID)
        {
            dynamic Product = (from p in db.Products
                               where p.Product_ID.Equals(ID)
                               select p).FirstOrDefault();

            // if no product was found.
            if (Product == null)
            {
                return false;
            }
            // if the product was found.
            else
            {
                return true;
            }
        }

        // this function takes an email and pasword,
        // then check if there is a user in the database who
        // matches given attributes.
        public bool login(string Email, string Password)
        {
            var FFieldUser = (from u in db.Users
                              where u.email.Equals(Email) &&
                              u.password.Equals(Secrecy.HashPassword(Password)
                             )
                              select u).FirstOrDefault();

            // if there is one or more users found.
            if (FFieldUser != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int register(User FFieldUser)
        {
            string type = "";

            if(FFieldUser.user_type == null)
            {
                type = "basic";
            }
            else if(FFieldUser.user_type.Equals("Manager"))
            {
                type = "Manager";
            }


            var NewUser = new User
            {
                first_name = FFieldUser.first_name,
                last_name = FFieldUser.last_name,
                email = FFieldUser.email,
                phone_number = FFieldUser.phone_number,
                address = FFieldUser.address,
                user_type = type,
                password = Secrecy.HashPassword(FFieldUser.password),
                zip_code = FFieldUser.zip_code,
                city = FFieldUser.city,
                province = FFieldUser.province
            };

            db.Users.InsertOnSubmit(NewUser);

            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                while (ex2.InnerException != null)
                {
                    ex2 = ex2.InnerException;
                }
                Console.WriteLine(ex.InnerException);
                throw;
                return -1;
            }
        }

        // this function takes an email and password,
        // then searchers for a user who matches the given
        // credition, if does not exists, then it means a user
        // is not yet registered.
        public bool registered(string Email, string Password)
        {
            dynamic UserReg = (from Reg in db.Users
                               where Reg.email.Equals(Email) &&
                                     Reg.password.Equals(Secrecy.HashPassword(Password))
                               select Reg).FirstOrDefault();

            if (UserReg == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Cart> getCartItems(string user_id)
        {

            var cartItems = (from u in db.Carts
                              where u.User_ID.Equals(user_id)
                              select u).ToList();

            return cartItems;
        }

        public bool alreadyInCart(int product_ID, string user_ID)
        {
            var item = (from x in db.Carts
                        where x.Product_ID.Equals(product_ID) && x.User_ID.Equals(user_ID)
                        select x).FirstOrDefault();

            if (item != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int addToCart(int product_ID, string user_ID)
        {
            if(alreadyInCart(product_ID,user_ID) == false)
            {
                var newCartItem = new Cart
                {
                    Product_ID = product_ID,
                    User_ID = Convert.ToInt32(user_ID)
                };

                db.Carts.InsertOnSubmit(newCartItem);

                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch (Exception ex)
                {
                    Exception ex2 = ex;
                    while (ex2.InnerException != null)
                    {
                        ex2 = ex2.InnerException;
                    }
                    Console.WriteLine(ex.InnerException);
                    throw;
                }
            }
            else
            {
                return 2;
            }

            // CartItems.Add(product_ID);
        }

        public int removeFromCart(int product_ID, string user_ID)
        {
            var CartItem = (from x in db.Carts
                            where x.Product_ID.Equals(product_ID) && x.User_ID.Equals(user_ID)
                            select x).FirstOrDefault();

            db.Carts.DeleteOnSubmit(CartItem);

            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                while (ex2.InnerException != null)
                {
                    ex2 = ex2.InnerException;
                }
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        public int GetNumCartItems(string user_id)
        {
            List<Cart> items = (from x in db.Carts
                             where x.User_ID.Equals(user_id)
                             select x).ToList();

            if (items != null)
            {
                return items.Count();
            }
            else
            {
                return 0;
            }
        }

        // searches the dababase for a given user,
        // a returns the user type.
        public string getUserType(string user_name)
        {

            var FFieldUser = (from u in db.Users
                              where u.email.Equals(user_name)
                              select u).FirstOrDefault();

            // if user exists.
            if (FFieldUser != null)
            {
                // return user type.
                return FFieldUser.user_type;
            } else
            {
                return null;
            }
        }

        public User GetUser(string username)
        {
            var FFieldUser = (from u in db.Users
                              where u.email.Equals(username)
                              select u).FirstOrDefault();
            User us = new User
            {
                User_ID = FFieldUser.User_ID,
                first_name = FFieldUser.first_name,
                last_name = FFieldUser.last_name,
                email = FFieldUser.email,
                phone_number = FFieldUser.phone_number,
                user_type = FFieldUser.user_type

            };
            return us;
        }

        public bool addNewProduct(string category, string name, string description, double price, double discount, string supplier)
        {
            Product newProduct = new Product
            {
                Product_Category = category,
                Product_Name = name,
                Product_Discount = Convert.ToInt32(discount),
                Product_Price = Convert.ToInt32(price),
                Product_Supplier = supplier,
                Product_Description = description
            };

            db.Products.InsertOnSubmit(newProduct);

            try
            {
                db.SubmitChanges();
                return true;
            } catch (Exception ex) {
                ex.GetBaseException();
                return false;
            }
        }

        public Product getProductByID(int id)
        {
            Product product = (from u in db.Products
                               where u.Product_ID.Equals(id)
                               select u).FirstOrDefault();

            return product;
        }

        public User getUserByID(string id)
        {
            System.Diagnostics.Debug.WriteLine(id);
            User user = (from u in db.Users
                       where u.email.Equals(id)
                       select u).FirstOrDefault();

            return user;
        }

        public List<Product> getAllProducts()
        {
            List<Product> allProducts = (from u in db.Products
                                         select u).ToList();

            return allProducts;
        }

        public List<Product> getAllProdcutsByType(string type)
        {
            List<Product> products = (from x in db.Products
                                      where x.Product_Category.Equals(type)
                                      select x).ToList();

            return products;
        }

        // checks if the user is in the database.
        public bool userExists(string id)
        {

            System.Diagnostics.Debug.WriteLine("Looking up: " + id);
            // retreive a user that marches the
            // following query.
            var user = (from u in db.Users
                        where u.email.Equals(id)
                        select u).FirstOrDefault();

            if (user == null)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public List<Wishlist> getWishlist(string user_id)
        {
            var listitems = (from u in db.Wishlists
                             where u.User_ID.Equals(user_id)
                             select u).ToList();

            return listitems;
        }

        public int addToWishList(int product_ID, string user_ID)
        {
            if(alreadyInWishlist(product_ID,user_ID) == false)
            {
                var newWishlistItem = new Wishlist
                {
                    Product_ID = product_ID,
                    User_ID = Convert.ToInt32(user_ID)
                };

                db.Wishlists.InsertOnSubmit(newWishlistItem);

                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch (Exception ex)
                {
                    Exception ex2 = ex;
                    while (ex2.InnerException != null)
                    {
                        ex2 = ex2.InnerException;
                    }
                    Console.WriteLine(ex.InnerException);
                    throw;
                }
            }
            else
            {
                return 2;
            }
        }

        public bool alreadyInWishlist(int product_ID, string user_ID)
        {
            var item = (from x in db.Wishlists
                        where x.Product_ID.Equals(product_ID) && x.User_ID.Equals(user_ID)
                        select x).FirstOrDefault();

            if (item != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int RemoveFromWishList(int product_ID, string user_ID)
        {
            var WishlistItem = (from x in db.Wishlists
                                where x.Product_ID.Equals(product_ID) && x.User_ID.Equals(user_ID)
                                select x).FirstOrDefault();

            db.Wishlists.DeleteOnSubmit(WishlistItem);

            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                while (ex2.InnerException != null)
                {
                    ex2 = ex2.InnerException;
                }
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        public int GenInvoice(int cartID, string dateTime, double total)
        {
            var invoice = new Invoice
            {
                Cart_ID = cartID,
                Date_Of_Issue = dateTime,
                Invoice_Total = total,
            };

            db.Invoices.InsertOnSubmit(invoice);

            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                while (ex2.InnerException != null)
                {
                    ex2 = ex2.InnerException;
                }
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        public int GetCart(int cart_ID)
        {
            Cart item = (from x in db.Carts
                         where x.User_ID.Equals(cart_ID)
                         select x).FirstOrDefault();

            if (item != null)
            {
                return item.Cart_ID;
            } else
            {
                return 0;
            }
        }

        public List<Invoice> getInvoice(string cartID)
        {
            var items = (from x in db.Invoices
                             where x.Cart_ID.Equals(cartID)
                             orderby x.Date_Of_Issue
                             select x).ToList();

            return items;
        }

        public Invoice getInvoiceByID(int invID)
        {
            Invoice inv = (from x in db.Invoices
                       where x.Invoice_ID.Equals(invID)
                       select x).FirstOrDefault();

            return inv;
        }

        public bool removeUserCart(string user_id)
        {
            var user_cart = (from u in db.Carts
                              where u.User_ID.Equals(user_id)
                              select u).FirstOrDefault();

            if (user_cart != null)
            {

                db.Carts.DeleteOnSubmit(user_cart);

                try
                {
                    db.SubmitChanges();
                } catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                return true;
            } else
            {
                return false;
            }
        }
    }
}
