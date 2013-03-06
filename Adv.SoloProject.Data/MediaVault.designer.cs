﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Adv.SoloProject.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DBNovak")]
	public partial class MediaVaultDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblCustomer(tblCustomer instance);
    partial void UpdatetblCustomer(tblCustomer instance);
    partial void DeletetblCustomer(tblCustomer instance);
    partial void InserttblMedia(tblMedia instance);
    partial void UpdatetblMedia(tblMedia instance);
    partial void DeletetblMedia(tblMedia instance);
    partial void InserttblFormat(tblFormat instance);
    partial void UpdatetblFormat(tblFormat instance);
    partial void DeletetblFormat(tblFormat instance);
    partial void InserttblMediaItem(tblMediaItem instance);
    partial void UpdatetblMediaItem(tblMediaItem instance);
    partial void DeletetblMediaItem(tblMediaItem instance);
    partial void InserttblMediaItemPricing(tblMediaItemPricing instance);
    partial void UpdatetblMediaItemPricing(tblMediaItemPricing instance);
    partial void DeletetblMediaItemPricing(tblMediaItemPricing instance);
    #endregion
		
		public MediaVaultDataContext() : 
				base(global::Adv.SoloProject.Data.Properties.Settings.Default.DBNovakConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MediaVaultDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MediaVaultDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MediaVaultDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MediaVaultDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblCustomer> tblCustomers
		{
			get
			{
				return this.GetTable<tblCustomer>();
			}
		}
		
		public System.Data.Linq.Table<tblMedia> tblMedias
		{
			get
			{
				return this.GetTable<tblMedia>();
			}
		}
		
		public System.Data.Linq.Table<tblFormat> tblFormats
		{
			get
			{
				return this.GetTable<tblFormat>();
			}
		}
		
		public System.Data.Linq.Table<tblMediaItem> tblMediaItems
		{
			get
			{
				return this.GetTable<tblMediaItem>();
			}
		}
		
		public System.Data.Linq.Table<tblMediaItemPricing> tblMediaItemPricings
		{
			get
			{
				return this.GetTable<tblMediaItemPricing>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblCustomer")]
	public partial class tblCustomer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Customer_Id;
		
		private string _AccountNumber;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Address;
		
		private string _City;
		
		private string _State;
		
		private string _Zip;
		
		private string _Phone;
		
		private string _Email;
		
		private System.Nullable<System.DateTime> _DateOfBirth;
		
		private int _CustomerStatus_Id;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomer_IdChanging(int value);
    partial void OnCustomer_IdChanged();
    partial void OnAccountNumberChanging(string value);
    partial void OnAccountNumberChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipChanging(string value);
    partial void OnZipChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDateOfBirthChanging(System.Nullable<System.DateTime> value);
    partial void OnDateOfBirthChanged();
    partial void OnCustomerStatus_IdChanging(int value);
    partial void OnCustomerStatus_IdChanged();
    #endregion
		
		public tblCustomer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Customer_Id
		{
			get
			{
				return this._Customer_Id;
			}
			set
			{
				if ((this._Customer_Id != value))
				{
					this.OnCustomer_IdChanging(value);
					this.SendPropertyChanging();
					this._Customer_Id = value;
					this.SendPropertyChanged("Customer_Id");
					this.OnCustomer_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountNumber", DbType="VarChar(64) NOT NULL", CanBeNull=false)]
		public string AccountNumber
		{
			get
			{
				return this._AccountNumber;
			}
			set
			{
				if ((this._AccountNumber != value))
				{
					this.OnAccountNumberChanging(value);
					this.SendPropertyChanging();
					this._AccountNumber = value;
					this.SendPropertyChanged("AccountNumber");
					this.OnAccountNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(32)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(32)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(48)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(24)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(2)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zip", DbType="VarChar(9)")]
		public string Zip
		{
			get
			{
				return this._Zip;
			}
			set
			{
				if ((this._Zip != value))
				{
					this.OnZipChanging(value);
					this.SendPropertyChanging();
					this._Zip = value;
					this.SendPropertyChanged("Zip");
					this.OnZipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(10)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(64)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="Date")]
		public System.Nullable<System.DateTime> DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._DateOfBirth = value;
					this.SendPropertyChanged("DateOfBirth");
					this.OnDateOfBirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerStatus_Id", DbType="Int NOT NULL")]
		public int CustomerStatus_Id
		{
			get
			{
				return this._CustomerStatus_Id;
			}
			set
			{
				if ((this._CustomerStatus_Id != value))
				{
					this.OnCustomerStatus_IdChanging(value);
					this.SendPropertyChanging();
					this._CustomerStatus_Id = value;
					this.SendPropertyChanged("CustomerStatus_Id");
					this.OnCustomerStatus_IdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblMedia")]
	public partial class tblMedia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Media_Id;
		
		private System.Nullable<System.DateTime> _ReleaseDate;
		
		private string _Title;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMedia_IdChanging(int value);
    partial void OnMedia_IdChanged();
    partial void OnReleaseDateChanging(System.Nullable<System.DateTime> value);
    partial void OnReleaseDateChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    #endregion
		
		public tblMedia()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Media_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Media_Id
		{
			get
			{
				return this._Media_Id;
			}
			set
			{
				if ((this._Media_Id != value))
				{
					this.OnMedia_IdChanging(value);
					this.SendPropertyChanging();
					this._Media_Id = value;
					this.SendPropertyChanged("Media_Id");
					this.OnMedia_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReleaseDate", DbType="Date")]
		public System.Nullable<System.DateTime> ReleaseDate
		{
			get
			{
				return this._ReleaseDate;
			}
			set
			{
				if ((this._ReleaseDate != value))
				{
					this.OnReleaseDateChanging(value);
					this.SendPropertyChanging();
					this._ReleaseDate = value;
					this.SendPropertyChanged("ReleaseDate");
					this.OnReleaseDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(64)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblFormat")]
	public partial class tblFormat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Format_Id;
		
		private string _Description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFormat_IdChanging(int value);
    partial void OnFormat_IdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public tblFormat()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Format_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Format_Id
		{
			get
			{
				return this._Format_Id;
			}
			set
			{
				if ((this._Format_Id != value))
				{
					this.OnFormat_IdChanging(value);
					this.SendPropertyChanging();
					this._Format_Id = value;
					this.SendPropertyChanged("Format_Id");
					this.OnFormat_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(16)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblMediaItem")]
	public partial class tblMediaItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MediaItem_Id;
		
		private System.Nullable<System.DateTime> _InvetoryDate;
		
		private int _Media_Id;
		
		private int _MediaItemState_Id;
		
		private int _MediaItemPricingId;
		
		private int _Format_Id;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMediaItem_IdChanging(int value);
    partial void OnMediaItem_IdChanged();
    partial void OnInvetoryDateChanging(System.Nullable<System.DateTime> value);
    partial void OnInvetoryDateChanged();
    partial void OnMedia_IdChanging(int value);
    partial void OnMedia_IdChanged();
    partial void OnMediaItemState_IdChanging(int value);
    partial void OnMediaItemState_IdChanged();
    partial void OnMediaItemPricingIdChanging(int value);
    partial void OnMediaItemPricingIdChanged();
    partial void OnFormat_IdChanging(int value);
    partial void OnFormat_IdChanged();
    #endregion
		
		public tblMediaItem()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MediaItem_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MediaItem_Id
		{
			get
			{
				return this._MediaItem_Id;
			}
			set
			{
				if ((this._MediaItem_Id != value))
				{
					this.OnMediaItem_IdChanging(value);
					this.SendPropertyChanging();
					this._MediaItem_Id = value;
					this.SendPropertyChanged("MediaItem_Id");
					this.OnMediaItem_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InvetoryDate", DbType="Date")]
		public System.Nullable<System.DateTime> InvetoryDate
		{
			get
			{
				return this._InvetoryDate;
			}
			set
			{
				if ((this._InvetoryDate != value))
				{
					this.OnInvetoryDateChanging(value);
					this.SendPropertyChanging();
					this._InvetoryDate = value;
					this.SendPropertyChanged("InvetoryDate");
					this.OnInvetoryDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Media_Id", DbType="Int NOT NULL")]
		public int Media_Id
		{
			get
			{
				return this._Media_Id;
			}
			set
			{
				if ((this._Media_Id != value))
				{
					this.OnMedia_IdChanging(value);
					this.SendPropertyChanging();
					this._Media_Id = value;
					this.SendPropertyChanged("Media_Id");
					this.OnMedia_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MediaItemState_Id", DbType="Int NOT NULL")]
		public int MediaItemState_Id
		{
			get
			{
				return this._MediaItemState_Id;
			}
			set
			{
				if ((this._MediaItemState_Id != value))
				{
					this.OnMediaItemState_IdChanging(value);
					this.SendPropertyChanging();
					this._MediaItemState_Id = value;
					this.SendPropertyChanged("MediaItemState_Id");
					this.OnMediaItemState_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MediaItemPricingId", DbType="Int NOT NULL")]
		public int MediaItemPricingId
		{
			get
			{
				return this._MediaItemPricingId;
			}
			set
			{
				if ((this._MediaItemPricingId != value))
				{
					this.OnMediaItemPricingIdChanging(value);
					this.SendPropertyChanging();
					this._MediaItemPricingId = value;
					this.SendPropertyChanged("MediaItemPricingId");
					this.OnMediaItemPricingIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Format_Id", DbType="Int NOT NULL")]
		public int Format_Id
		{
			get
			{
				return this._Format_Id;
			}
			set
			{
				if ((this._Format_Id != value))
				{
					this.OnFormat_IdChanging(value);
					this.SendPropertyChanging();
					this._Format_Id = value;
					this.SendPropertyChanged("Format_Id");
					this.OnFormat_IdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblMediaItemPricing")]
	public partial class tblMediaItemPricing : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MediaItemPricing_Id;
		
		private string _Description;
		
		private System.Nullable<decimal> _Price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMediaItemPricing_IdChanging(int value);
    partial void OnMediaItemPricing_IdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    #endregion
		
		public tblMediaItemPricing()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MediaItemPricing_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MediaItemPricing_Id
		{
			get
			{
				return this._MediaItemPricing_Id;
			}
			set
			{
				if ((this._MediaItemPricing_Id != value))
				{
					this.OnMediaItemPricing_IdChanging(value);
					this.SendPropertyChanging();
					this._MediaItemPricing_Id = value;
					this.SendPropertyChanged("MediaItemPricing_Id");
					this.OnMediaItemPricing_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(16)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(2,0)")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
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