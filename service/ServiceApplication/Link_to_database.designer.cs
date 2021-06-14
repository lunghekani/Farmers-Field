﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceApplication
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="New Database")]
	public partial class Link_to_databaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCart(Cart instance);
    partial void UpdateCart(Cart instance);
    partial void DeleteCart(Cart instance);
    partial void InsertReport(Report instance);
    partial void UpdateReport(Report instance);
    partial void DeleteReport(Report instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertWishlist(Wishlist instance);
    partial void UpdateWishlist(Wishlist instance);
    partial void DeleteWishlist(Wishlist instance);
    partial void InsertInvoice(Invoice instance);
    partial void UpdateInvoice(Invoice instance);
    partial void DeleteInvoice(Invoice instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    #endregion
		
		public Link_to_databaseDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["New_DatabaseConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Link_to_databaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Link_to_databaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Link_to_databaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Link_to_databaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cart> Carts
		{
			get
			{
				return this.GetTable<Cart>();
			}
		}
		
		public System.Data.Linq.Table<Report> Reports
		{
			get
			{
				return this.GetTable<Report>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Wishlist> Wishlists
		{
			get
			{
				return this.GetTable<Wishlist>();
			}
		}
		
		public System.Data.Linq.Table<Invoice> Invoices
		{
			get
			{
				return this.GetTable<Invoice>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cart")]
	public partial class Cart : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Cart_ID;
		
		private int _User_ID;
		
		private int _Product_ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCart_IDChanging(int value);
    partial void OnCart_IDChanged();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnProduct_IDChanging(int value);
    partial void OnProduct_IDChanged();
    #endregion
		
		public Cart()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cart_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Cart_ID
		{
			get
			{
				return this._Cart_ID;
			}
			set
			{
				if ((this._Cart_ID != value))
				{
					this.OnCart_IDChanging(value);
					this.SendPropertyChanging();
					this._Cart_ID = value;
					this.SendPropertyChanged("Cart_ID");
					this.OnCart_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL")]
		public int User_ID
		{
			get
			{
				return this._User_ID;
			}
			set
			{
				if ((this._User_ID != value))
				{
					this.OnUser_IDChanging(value);
					this.SendPropertyChanging();
					this._User_ID = value;
					this.SendPropertyChanged("User_ID");
					this.OnUser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_ID", DbType="Int NOT NULL")]
		public int Product_ID
		{
			get
			{
				return this._Product_ID;
			}
			set
			{
				if ((this._Product_ID != value))
				{
					this.OnProduct_IDChanging(value);
					this.SendPropertyChanging();
					this._Product_ID = value;
					this.SendPropertyChanged("Product_ID");
					this.OnProduct_IDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reports")]
	public partial class Report : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Report_ID;
		
		private System.Nullable<int> _User_ID;
		
		private System.Nullable<int> _Product_ID;
		
		private System.Nullable<int> _Num_Registered_Users;
		
		private System.Nullable<int> _Num_Products_Sold;
		
		private System.Nullable<int> _Total_Profit;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReport_IDChanging(int value);
    partial void OnReport_IDChanged();
    partial void OnUser_IDChanging(System.Nullable<int> value);
    partial void OnUser_IDChanged();
    partial void OnProduct_IDChanging(System.Nullable<int> value);
    partial void OnProduct_IDChanged();
    partial void OnNum_Registered_UsersChanging(System.Nullable<int> value);
    partial void OnNum_Registered_UsersChanged();
    partial void OnNum_Products_SoldChanging(System.Nullable<int> value);
    partial void OnNum_Products_SoldChanged();
    partial void OnTotal_ProfitChanging(System.Nullable<int> value);
    partial void OnTotal_ProfitChanged();
    #endregion
		
		public Report()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Report_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Report_ID
		{
			get
			{
				return this._Report_ID;
			}
			set
			{
				if ((this._Report_ID != value))
				{
					this.OnReport_IDChanging(value);
					this.SendPropertyChanging();
					this._Report_ID = value;
					this.SendPropertyChanged("Report_ID");
					this.OnReport_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int")]
		public System.Nullable<int> User_ID
		{
			get
			{
				return this._User_ID;
			}
			set
			{
				if ((this._User_ID != value))
				{
					this.OnUser_IDChanging(value);
					this.SendPropertyChanging();
					this._User_ID = value;
					this.SendPropertyChanged("User_ID");
					this.OnUser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_ID", DbType="Int")]
		public System.Nullable<int> Product_ID
		{
			get
			{
				return this._Product_ID;
			}
			set
			{
				if ((this._Product_ID != value))
				{
					this.OnProduct_IDChanging(value);
					this.SendPropertyChanging();
					this._Product_ID = value;
					this.SendPropertyChanged("Product_ID");
					this.OnProduct_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Registered_Users", DbType="Int")]
		public System.Nullable<int> Num_Registered_Users
		{
			get
			{
				return this._Num_Registered_Users;
			}
			set
			{
				if ((this._Num_Registered_Users != value))
				{
					this.OnNum_Registered_UsersChanging(value);
					this.SendPropertyChanging();
					this._Num_Registered_Users = value;
					this.SendPropertyChanged("Num_Registered_Users");
					this.OnNum_Registered_UsersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Products_Sold", DbType="Int")]
		public System.Nullable<int> Num_Products_Sold
		{
			get
			{
				return this._Num_Products_Sold;
			}
			set
			{
				if ((this._Num_Products_Sold != value))
				{
					this.OnNum_Products_SoldChanging(value);
					this.SendPropertyChanging();
					this._Num_Products_Sold = value;
					this.SendPropertyChanged("Num_Products_Sold");
					this.OnNum_Products_SoldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Profit", DbType="Int")]
		public System.Nullable<int> Total_Profit
		{
			get
			{
				return this._Total_Profit;
			}
			set
			{
				if ((this._Total_Profit != value))
				{
					this.OnTotal_ProfitChanging(value);
					this.SendPropertyChanging();
					this._Total_Profit = value;
					this.SendPropertyChanged("Total_Profit");
					this.OnTotal_ProfitChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _User_ID;
		
		private string _first_name;
		
		private string _last_name;
		
		private string _email;
		
		private string _phone_number;
		
		private string _address;
		
		private string _user_type;
		
		private string _active;
		
		private string _password;
		
		private string _city;
		
		private string _province;
		
		private string _zip_code;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void Onphone_numberChanging(string value);
    partial void Onphone_numberChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void Onuser_typeChanging(string value);
    partial void Onuser_typeChanged();
    partial void OnactiveChanging(string value);
    partial void OnactiveChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void OnprovinceChanging(string value);
    partial void OnprovinceChanged();
    partial void Onzip_codeChanging(string value);
    partial void Onzip_codeChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int User_ID
		{
			get
			{
				return this._User_ID;
			}
			set
			{
				if ((this._User_ID != value))
				{
					this.OnUser_IDChanging(value);
					this.SendPropertyChanging();
					this._User_ID = value;
					this.SendPropertyChanged("User_ID");
					this.OnUser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="NVarChar(50)")]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="NVarChar(50)")]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone_number", DbType="NChar(10)")]
		public string phone_number
		{
			get
			{
				return this._phone_number;
			}
			set
			{
				if ((this._phone_number != value))
				{
					this.Onphone_numberChanging(value);
					this.SendPropertyChanging();
					this._phone_number = value;
					this.SendPropertyChanged("phone_number");
					this.Onphone_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NVarChar(MAX)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_type", DbType="VarChar(50)")]
		public string user_type
		{
			get
			{
				return this._user_type;
			}
			set
			{
				if ((this._user_type != value))
				{
					this.Onuser_typeChanging(value);
					this.SendPropertyChanging();
					this._user_type = value;
					this.SendPropertyChanged("user_type");
					this.Onuser_typeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active", DbType="NChar(10)")]
		public string active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((this._active != value))
				{
					this.OnactiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("active");
					this.OnactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(MAX)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="NVarChar(50)")]
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_province", DbType="NVarChar(50)")]
		public string province
		{
			get
			{
				return this._province;
			}
			set
			{
				if ((this._province != value))
				{
					this.OnprovinceChanging(value);
					this.SendPropertyChanging();
					this._province = value;
					this.SendPropertyChanged("province");
					this.OnprovinceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zip_code", DbType="NChar(10)")]
		public string zip_code
		{
			get
			{
				return this._zip_code;
			}
			set
			{
				if ((this._zip_code != value))
				{
					this.Onzip_codeChanging(value);
					this.SendPropertyChanging();
					this._zip_code = value;
					this.SendPropertyChanged("zip_code");
					this.Onzip_codeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Wishlist")]
	public partial class Wishlist : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Wishlist_ID;
		
		private int _User_ID;
		
		private int _Product_ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnWishlist_IDChanging(int value);
    partial void OnWishlist_IDChanged();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnProduct_IDChanging(int value);
    partial void OnProduct_IDChanged();
    #endregion
		
		public Wishlist()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Wishlist_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Wishlist_ID
		{
			get
			{
				return this._Wishlist_ID;
			}
			set
			{
				if ((this._Wishlist_ID != value))
				{
					this.OnWishlist_IDChanging(value);
					this.SendPropertyChanging();
					this._Wishlist_ID = value;
					this.SendPropertyChanged("Wishlist_ID");
					this.OnWishlist_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL")]
		public int User_ID
		{
			get
			{
				return this._User_ID;
			}
			set
			{
				if ((this._User_ID != value))
				{
					this.OnUser_IDChanging(value);
					this.SendPropertyChanging();
					this._User_ID = value;
					this.SendPropertyChanged("User_ID");
					this.OnUser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_ID", DbType="Int NOT NULL")]
		public int Product_ID
		{
			get
			{
				return this._Product_ID;
			}
			set
			{
				if ((this._Product_ID != value))
				{
					this.OnProduct_IDChanging(value);
					this.SendPropertyChanging();
					this._Product_ID = value;
					this.SendPropertyChanged("Product_ID");
					this.OnProduct_IDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Invoice")]
	public partial class Invoice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Invoice_ID;
		
		private System.Nullable<int> _Cart_ID;
		
		private System.Nullable<int> _User_ID;
		
		private string _Date_Of_Issue;
		
		private System.Nullable<double> _Invoice_Total;
		
		private System.Nullable<int> _Quantity_Bought;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInvoice_IDChanging(int value);
    partial void OnInvoice_IDChanged();
    partial void OnCart_IDChanging(System.Nullable<int> value);
    partial void OnCart_IDChanged();
    partial void OnUser_IDChanging(System.Nullable<int> value);
    partial void OnUser_IDChanged();
    partial void OnDate_Of_IssueChanging(string value);
    partial void OnDate_Of_IssueChanged();
    partial void OnInvoice_TotalChanging(System.Nullable<double> value);
    partial void OnInvoice_TotalChanged();
    partial void OnQuantity_BoughtChanging(System.Nullable<int> value);
    partial void OnQuantity_BoughtChanged();
    #endregion
		
		public Invoice()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Invoice_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Invoice_ID
		{
			get
			{
				return this._Invoice_ID;
			}
			set
			{
				if ((this._Invoice_ID != value))
				{
					this.OnInvoice_IDChanging(value);
					this.SendPropertyChanging();
					this._Invoice_ID = value;
					this.SendPropertyChanged("Invoice_ID");
					this.OnInvoice_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cart_ID", DbType="Int")]
		public System.Nullable<int> Cart_ID
		{
			get
			{
				return this._Cart_ID;
			}
			set
			{
				if ((this._Cart_ID != value))
				{
					this.OnCart_IDChanging(value);
					this.SendPropertyChanging();
					this._Cart_ID = value;
					this.SendPropertyChanged("Cart_ID");
					this.OnCart_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int")]
		public System.Nullable<int> User_ID
		{
			get
			{
				return this._User_ID;
			}
			set
			{
				if ((this._User_ID != value))
				{
					this.OnUser_IDChanging(value);
					this.SendPropertyChanging();
					this._User_ID = value;
					this.SendPropertyChanged("User_ID");
					this.OnUser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date_Of_Issue", DbType="VarChar(255)")]
		public string Date_Of_Issue
		{
			get
			{
				return this._Date_Of_Issue;
			}
			set
			{
				if ((this._Date_Of_Issue != value))
				{
					this.OnDate_Of_IssueChanging(value);
					this.SendPropertyChanging();
					this._Date_Of_Issue = value;
					this.SendPropertyChanged("Date_Of_Issue");
					this.OnDate_Of_IssueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Invoice_Total", DbType="Float")]
		public System.Nullable<double> Invoice_Total
		{
			get
			{
				return this._Invoice_Total;
			}
			set
			{
				if ((this._Invoice_Total != value))
				{
					this.OnInvoice_TotalChanging(value);
					this.SendPropertyChanging();
					this._Invoice_Total = value;
					this.SendPropertyChanged("Invoice_Total");
					this.OnInvoice_TotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity_Bought", DbType="Int")]
		public System.Nullable<int> Quantity_Bought
		{
			get
			{
				return this._Quantity_Bought;
			}
			set
			{
				if ((this._Quantity_Bought != value))
				{
					this.OnQuantity_BoughtChanging(value);
					this.SendPropertyChanging();
					this._Quantity_Bought = value;
					this.SendPropertyChanged("Quantity_Bought");
					this.OnQuantity_BoughtChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Product_ID;
		
		private string _Product_Category;
		
		private string _Product_Name;
		
		private string _Product_Description;
		
		private decimal _Product_Price;
		
		private System.Nullable<decimal> _Product_Discount;
		
		private string _Product_Supplier;
		
		private string _Product_Image;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProduct_IDChanging(int value);
    partial void OnProduct_IDChanged();
    partial void OnProduct_CategoryChanging(string value);
    partial void OnProduct_CategoryChanged();
    partial void OnProduct_NameChanging(string value);
    partial void OnProduct_NameChanged();
    partial void OnProduct_DescriptionChanging(string value);
    partial void OnProduct_DescriptionChanged();
    partial void OnProduct_PriceChanging(decimal value);
    partial void OnProduct_PriceChanged();
    partial void OnProduct_DiscountChanging(System.Nullable<decimal> value);
    partial void OnProduct_DiscountChanged();
    partial void OnProduct_SupplierChanging(string value);
    partial void OnProduct_SupplierChanged();
    partial void OnProduct_ImageChanging(string value);
    partial void OnProduct_ImageChanged();
    #endregion
		
		public Product()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Product_ID
		{
			get
			{
				return this._Product_ID;
			}
			set
			{
				if ((this._Product_ID != value))
				{
					this.OnProduct_IDChanging(value);
					this.SendPropertyChanging();
					this._Product_ID = value;
					this.SendPropertyChanged("Product_ID");
					this.OnProduct_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Category", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Product_Category
		{
			get
			{
				return this._Product_Category;
			}
			set
			{
				if ((this._Product_Category != value))
				{
					this.OnProduct_CategoryChanging(value);
					this.SendPropertyChanging();
					this._Product_Category = value;
					this.SendPropertyChanged("Product_Category");
					this.OnProduct_CategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Product_Name
		{
			get
			{
				return this._Product_Name;
			}
			set
			{
				if ((this._Product_Name != value))
				{
					this.OnProduct_NameChanging(value);
					this.SendPropertyChanging();
					this._Product_Name = value;
					this.SendPropertyChanged("Product_Name");
					this.OnProduct_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Description", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Product_Description
		{
			get
			{
				return this._Product_Description;
			}
			set
			{
				if ((this._Product_Description != value))
				{
					this.OnProduct_DescriptionChanging(value);
					this.SendPropertyChanging();
					this._Product_Description = value;
					this.SendPropertyChanged("Product_Description");
					this.OnProduct_DescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Price", DbType="Money NOT NULL")]
		public decimal Product_Price
		{
			get
			{
				return this._Product_Price;
			}
			set
			{
				if ((this._Product_Price != value))
				{
					this.OnProduct_PriceChanging(value);
					this.SendPropertyChanging();
					this._Product_Price = value;
					this.SendPropertyChanged("Product_Price");
					this.OnProduct_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Discount", DbType="Money")]
		public System.Nullable<decimal> Product_Discount
		{
			get
			{
				return this._Product_Discount;
			}
			set
			{
				if ((this._Product_Discount != value))
				{
					this.OnProduct_DiscountChanging(value);
					this.SendPropertyChanging();
					this._Product_Discount = value;
					this.SendPropertyChanged("Product_Discount");
					this.OnProduct_DiscountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Supplier", DbType="NChar(10)")]
		public string Product_Supplier
		{
			get
			{
				return this._Product_Supplier;
			}
			set
			{
				if ((this._Product_Supplier != value))
				{
					this.OnProduct_SupplierChanging(value);
					this.SendPropertyChanging();
					this._Product_Supplier = value;
					this.SendPropertyChanged("Product_Supplier");
					this.OnProduct_SupplierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Image", DbType="VarChar(255)")]
		public string Product_Image
		{
			get
			{
				return this._Product_Image;
			}
			set
			{
				if ((this._Product_Image != value))
				{
					this.OnProduct_ImageChanging(value);
					this.SendPropertyChanging();
					this._Product_Image = value;
					this.SendPropertyChanged("Product_Image");
					this.OnProduct_ImageChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591