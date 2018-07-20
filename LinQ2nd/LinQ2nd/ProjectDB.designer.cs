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

namespace LinQ2nd
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db")]
	public partial class ProjectDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcategory(category instance);
    partial void Updatecategory(category instance);
    partial void Deletecategory(category instance);
    partial void InsertEmployeeDetail(EmployeeDetail instance);
    partial void UpdateEmployeeDetail(EmployeeDetail instance);
    partial void DeleteEmployeeDetail(EmployeeDetail instance);
    partial void Insertcustomer(customer instance);
    partial void Updatecustomer(customer instance);
    partial void Deletecustomer(customer instance);
    #endregion
		
		public ProjectDBDataContext() : 
				base(global::LinQ2nd.Properties.Settings.Default.dbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<category> categories
		{
			get
			{
				return this.GetTable<category>();
			}
		}
		
		public System.Data.Linq.Table<EmployeeDetail> EmployeeDetails
		{
			get
			{
				return this.GetTable<EmployeeDetail>();
			}
		}
		
		public System.Data.Linq.Table<customer> customers
		{
			get
			{
				return this.GetTable<customer>();
			}
		}
		
		public System.Data.Linq.Table<product1> product1s
		{
			get
			{
				return this.GetTable<product1>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.category")]
	public partial class category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _categoryID;
		
		private string _categoryName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncategoryIDChanging(int value);
    partial void OncategoryIDChanged();
    partial void OncategoryNameChanging(string value);
    partial void OncategoryNameChanged();
    #endregion
		
		public category()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoryID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int categoryID
		{
			get
			{
				return this._categoryID;
			}
			set
			{
				if ((this._categoryID != value))
				{
					this.OncategoryIDChanging(value);
					this.SendPropertyChanging();
					this._categoryID = value;
					this.SendPropertyChanged("categoryID");
					this.OncategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoryName", DbType="VarChar(50)")]
		public string categoryName
		{
			get
			{
				return this._categoryName;
			}
			set
			{
				if ((this._categoryName != value))
				{
					this.OncategoryNameChanging(value);
					this.SendPropertyChanging();
					this._categoryName = value;
					this.SendPropertyChanged("categoryName");
					this.OncategoryNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmployeeDetails")]
	public partial class EmployeeDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmpID;
		
		private string _EmpName;
		
		private System.Nullable<int> _DeptCode;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpIDChanging(int value);
    partial void OnEmpIDChanged();
    partial void OnEmpNameChanging(string value);
    partial void OnEmpNameChanged();
    partial void OnDeptCodeChanging(System.Nullable<int> value);
    partial void OnDeptCodeChanged();
    #endregion
		
		public EmployeeDetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EmpID
		{
			get
			{
				return this._EmpID;
			}
			set
			{
				if ((this._EmpID != value))
				{
					this.OnEmpIDChanging(value);
					this.SendPropertyChanging();
					this._EmpID = value;
					this.SendPropertyChanged("EmpID");
					this.OnEmpIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpName", DbType="VarChar(50)")]
		public string EmpName
		{
			get
			{
				return this._EmpName;
			}
			set
			{
				if ((this._EmpName != value))
				{
					this.OnEmpNameChanging(value);
					this.SendPropertyChanging();
					this._EmpName = value;
					this.SendPropertyChanged("EmpName");
					this.OnEmpNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptCode", DbType="Int")]
		public System.Nullable<int> DeptCode
		{
			get
			{
				return this._DeptCode;
			}
			set
			{
				if ((this._DeptCode != value))
				{
					this.OnDeptCodeChanging(value);
					this.SendPropertyChanging();
					this._DeptCode = value;
					this.SendPropertyChanged("DeptCode");
					this.OnDeptCodeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.customer")]
	public partial class customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerID;
		
		private string _CustomerName;
		
		private string _CustomerMail;
		
		private string _Location;
		
		private System.Nullable<System.DateTime> _DOB;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnCustomerNameChanging(string value);
    partial void OnCustomerNameChanged();
    partial void OnCustomerMailChanging(string value);
    partial void OnCustomerMailChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    partial void OnDOBChanging(System.Nullable<System.DateTime> value);
    partial void OnDOBChanged();
    #endregion
		
		public customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerName", DbType="VarChar(100)")]
		public string CustomerName
		{
			get
			{
				return this._CustomerName;
			}
			set
			{
				if ((this._CustomerName != value))
				{
					this.OnCustomerNameChanging(value);
					this.SendPropertyChanging();
					this._CustomerName = value;
					this.SendPropertyChanged("CustomerName");
					this.OnCustomerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerMail", DbType="VarChar(50)")]
		public string CustomerMail
		{
			get
			{
				return this._CustomerMail;
			}
			set
			{
				if ((this._CustomerMail != value))
				{
					this.OnCustomerMailChanging(value);
					this.SendPropertyChanging();
					this._CustomerMail = value;
					this.SendPropertyChanged("CustomerMail");
					this.OnCustomerMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="VarChar(100)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this.OnLocationChanging(value);
					this.SendPropertyChanging();
					this._Location = value;
					this.SendPropertyChanged("Location");
					this.OnLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="Date")]
		public System.Nullable<System.DateTime> DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.product")]
	public partial class product1
	{
		
		private System.Nullable<int> _categoryID;
		
		private System.Nullable<int> _productID;
		
		private string _productName;
		
		private string _productLocation;
		
		private System.Nullable<decimal> _productCost;
		
		private System.Nullable<int> _productLocalTransport;
		
		public product1()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoryID", DbType="Int")]
		public System.Nullable<int> categoryID
		{
			get
			{
				return this._categoryID;
			}
			set
			{
				if ((this._categoryID != value))
				{
					this._categoryID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productID", DbType="Int")]
		public System.Nullable<int> productID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((this._productID != value))
				{
					this._productID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productName", DbType="VarChar(50)")]
		public string productName
		{
			get
			{
				return this._productName;
			}
			set
			{
				if ((this._productName != value))
				{
					this._productName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productLocation", DbType="VarChar(50)")]
		public string productLocation
		{
			get
			{
				return this._productLocation;
			}
			set
			{
				if ((this._productLocation != value))
				{
					this._productLocation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productCost", DbType="Money")]
		public System.Nullable<decimal> productCost
		{
			get
			{
				return this._productCost;
			}
			set
			{
				if ((this._productCost != value))
				{
					this._productCost = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productLocalTransport", DbType="Int")]
		public System.Nullable<int> productLocalTransport
		{
			get
			{
				return this._productLocalTransport;
			}
			set
			{
				if ((this._productLocalTransport != value))
				{
					this._productLocalTransport = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
