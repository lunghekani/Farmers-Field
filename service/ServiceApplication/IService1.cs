using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool login(string Email, string Password);

        [OperationContract]
        int register(User FFieldUser);

        [OperationContract]
        bool registered(string Email, string Password);

        [OperationContract]
        bool isNewProduct(string ID);

        [OperationContract]
        bool addNewProduct(string category, string name, string description, double price, double discount, string supplier);

        [OperationContract]
        bool AddProduct(Product Prod);

        [OperationContract]
        bool editProduct(Product Aug, int ID);

        [OperationContract]
        bool removeProduct(int ID);

        [OperationContract]
        List<Product> getAllProducts();

        [OperationContract]
        List<Product> getAllProdcutsByType(string type);

        [OperationContract]
        Product getProductByID(int id);

        [OperationContract]
        string getUserType(string user_name);

        [OperationContract]
        int FindProductBeingSearched_ID(string ID);

        [OperationContract]
        Product getProduct(string ID);

        [OperationContract]
        User GetUser(string username);

        [OperationContract]
        User getUserByID(string id);

        [OperationContract]
        bool userExists(string id);

        [OperationContract]
        List<Cart> getCartItems(string user_id);

        [OperationContract]
        int addToCart(int product_ID, string user_ID);

        [OperationContract]
        bool alreadyInCart(int product_ID, string user_ID);

        [OperationContract]
        bool removeUserCart(string user_id);

        [OperationContract]
        int removeFromCart(int product_ID, string user_ID);

        [OperationContract]
        int GetNumCartItems(string user_id);

        [OperationContract]
        List<Wishlist> getWishlist(string user_id);

        [OperationContract]
        int addToWishList(int product_ID, string user_ID);

        [OperationContract]
        bool alreadyInWishlist(int product_ID, string user_ID);

        [OperationContract]
        int RemoveFromWishList(int product_ID, string user_ID);

        [OperationContract]
        int GenInvoice(int cartID, string dateTime, double total);

        [OperationContract]
        int GetCart(int cart_ID);

        [OperationContract]
        List<Invoice> getInvoice(string userID);

        [OperationContract]
        Invoice getInvoiceByID(int invoiceID);
    }
}
