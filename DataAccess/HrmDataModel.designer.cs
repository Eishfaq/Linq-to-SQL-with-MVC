﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HRM_First")]
	public partial class HrmDataModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    partial void InsertDesignation(Designation instance);
    partial void UpdateDesignation(Designation instance);
    partial void DeleteDesignation(Designation instance);
    partial void InsertDocument(Document instance);
    partial void UpdateDocument(Document instance);
    partial void DeleteDocument(Document instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertJobLocation(JobLocation instance);
    partial void UpdateJobLocation(JobLocation instance);
    partial void DeleteJobLocation(JobLocation instance);
    #endregion
		
		public HrmDataModelDataContext() : 
				base(global::DataAccess.Properties.Settings.Default.HRM_FirstConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HrmDataModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HrmDataModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HrmDataModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HrmDataModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Department> Departments
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
		
		public System.Data.Linq.Table<Designation> Designations
		{
			get
			{
				return this.GetTable<Designation>();
			}
		}
		
		public System.Data.Linq.Table<Document> Documents
		{
			get
			{
				return this.GetTable<Document>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<JobLocation> JobLocations
		{
			get
			{
				return this.GetTable<JobLocation>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Departments")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _D_Description;
		
		private EntitySet<Employee> _Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnD_DescriptionChanging(string value);
    partial void OnD_DescriptionChanged();
    #endregion
		
		public Department()
		{
			this._Employees = new EntitySet<Employee>(new Action<Employee>(this.attach_Employees), new Action<Employee>(this.detach_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_D_Description", DbType="VarChar(50)")]
		public string D_Description
		{
			get
			{
				return this._D_Description;
			}
			set
			{
				if ((this._D_Description != value))
				{
					this.OnD_DescriptionChanging(value);
					this.SendPropertyChanging();
					this._D_Description = value;
					this.SendPropertyChanged("D_Description");
					this.OnD_DescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Employees", ThisKey="Id", OtherKey="Department_Id")]
		public EntitySet<Employee> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
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
		
		private void attach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = this;
		}
		
		private void detach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Designations")]
	public partial class Designation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Desig_Description;
		
		private EntitySet<Employee> _Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDesig_DescriptionChanging(string value);
    partial void OnDesig_DescriptionChanged();
    #endregion
		
		public Designation()
		{
			this._Employees = new EntitySet<Employee>(new Action<Employee>(this.attach_Employees), new Action<Employee>(this.detach_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desig_Description", DbType="VarChar(50)")]
		public string Desig_Description
		{
			get
			{
				return this._Desig_Description;
			}
			set
			{
				if ((this._Desig_Description != value))
				{
					this.OnDesig_DescriptionChanging(value);
					this.SendPropertyChanging();
					this._Desig_Description = value;
					this.SendPropertyChanged("Desig_Description");
					this.OnDesig_DescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Designation_Employee", Storage="_Employees", ThisKey="Id", OtherKey="Designation_Id")]
		public EntitySet<Employee> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
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
		
		private void attach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Designation = this;
		}
		
		private void detach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Designation = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Documents")]
	public partial class Document : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _EmployeeId;
		
		private string _File_Name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmployeeIdChanging(System.Nullable<int> value);
    partial void OnEmployeeIdChanged();
    partial void OnFile_NameChanging(string value);
    partial void OnFile_NameChanged();
    #endregion
		
		public Document()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="Int")]
		public System.Nullable<int> EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_File_Name", DbType="VarChar(250)")]
		public string File_Name
		{
			get
			{
				return this._File_Name;
			}
			set
			{
				if ((this._File_Name != value))
				{
					this.OnFile_NameChanging(value);
					this.SendPropertyChanging();
					this._File_Name = value;
					this.SendPropertyChanged("File_Name");
					this.OnFile_NameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _First_Name;
		
		private string _Middle_Name;
		
		private string _Last_Name;
		
		private System.Nullable<System.DateTime> _DOB;
		
		private string _Gender;
		
		private string _PresentAddress;
		
		private string _PermanentAddress;
		
		private string _Email_Address;
		
		private string _Mobile_Number;
		
		private string _Marital_Status;
		
		private string _Fathers_Name;
		
		private string _Mothers_Name;
		
		private System.Nullable<int> _Department_Id;
		
		private System.Nullable<int> _Designation_Id;
		
		private System.Nullable<int> _JobLocation_Id;
		
		private EntityRef<Department> _Department;
		
		private EntityRef<Designation> _Designation;
		
		private EntityRef<JobLocation> _JobLocation;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnMiddle_NameChanging(string value);
    partial void OnMiddle_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnDOBChanging(System.Nullable<System.DateTime> value);
    partial void OnDOBChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnPresentAddressChanging(string value);
    partial void OnPresentAddressChanged();
    partial void OnPermanentAddressChanging(string value);
    partial void OnPermanentAddressChanged();
    partial void OnEmail_AddressChanging(string value);
    partial void OnEmail_AddressChanged();
    partial void OnMobile_NumberChanging(string value);
    partial void OnMobile_NumberChanged();
    partial void OnMarital_StatusChanging(string value);
    partial void OnMarital_StatusChanged();
    partial void OnFathers_NameChanging(string value);
    partial void OnFathers_NameChanged();
    partial void OnMothers_NameChanging(string value);
    partial void OnMothers_NameChanged();
    partial void OnDepartment_IdChanging(System.Nullable<int> value);
    partial void OnDepartment_IdChanged();
    partial void OnDesignation_IdChanging(System.Nullable<int> value);
    partial void OnDesignation_IdChanged();
    partial void OnJobLocation_IdChanging(System.Nullable<int> value);
    partial void OnJobLocation_IdChanged();
    #endregion
		
		public Employee()
		{
			this._Department = default(EntityRef<Department>);
			this._Designation = default(EntityRef<Designation>);
			this._JobLocation = default(EntityRef<JobLocation>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="VarChar(50)")]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Middle_Name", DbType="VarChar(50)")]
		public string Middle_Name
		{
			get
			{
				return this._Middle_Name;
			}
			set
			{
				if ((this._Middle_Name != value))
				{
					this.OnMiddle_NameChanging(value);
					this.SendPropertyChanging();
					this._Middle_Name = value;
					this.SendPropertyChanged("Middle_Name");
					this.OnMiddle_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="VarChar(50)")]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="DateTime")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PresentAddress", DbType="VarChar(50)")]
		public string PresentAddress
		{
			get
			{
				return this._PresentAddress;
			}
			set
			{
				if ((this._PresentAddress != value))
				{
					this.OnPresentAddressChanging(value);
					this.SendPropertyChanging();
					this._PresentAddress = value;
					this.SendPropertyChanged("PresentAddress");
					this.OnPresentAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermanentAddress", DbType="VarChar(50)")]
		public string PermanentAddress
		{
			get
			{
				return this._PermanentAddress;
			}
			set
			{
				if ((this._PermanentAddress != value))
				{
					this.OnPermanentAddressChanging(value);
					this.SendPropertyChanging();
					this._PermanentAddress = value;
					this.SendPropertyChanged("PermanentAddress");
					this.OnPermanentAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email_Address", DbType="VarChar(50)")]
		public string Email_Address
		{
			get
			{
				return this._Email_Address;
			}
			set
			{
				if ((this._Email_Address != value))
				{
					this.OnEmail_AddressChanging(value);
					this.SendPropertyChanging();
					this._Email_Address = value;
					this.SendPropertyChanged("Email_Address");
					this.OnEmail_AddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile_Number", DbType="VarChar(50)")]
		public string Mobile_Number
		{
			get
			{
				return this._Mobile_Number;
			}
			set
			{
				if ((this._Mobile_Number != value))
				{
					this.OnMobile_NumberChanging(value);
					this.SendPropertyChanging();
					this._Mobile_Number = value;
					this.SendPropertyChanged("Mobile_Number");
					this.OnMobile_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Marital_Status", DbType="VarChar(50)")]
		public string Marital_Status
		{
			get
			{
				return this._Marital_Status;
			}
			set
			{
				if ((this._Marital_Status != value))
				{
					this.OnMarital_StatusChanging(value);
					this.SendPropertyChanging();
					this._Marital_Status = value;
					this.SendPropertyChanged("Marital_Status");
					this.OnMarital_StatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fathers_Name", DbType="VarChar(50)")]
		public string Fathers_Name
		{
			get
			{
				return this._Fathers_Name;
			}
			set
			{
				if ((this._Fathers_Name != value))
				{
					this.OnFathers_NameChanging(value);
					this.SendPropertyChanging();
					this._Fathers_Name = value;
					this.SendPropertyChanged("Fathers_Name");
					this.OnFathers_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mothers_Name", DbType="VarChar(50)")]
		public string Mothers_Name
		{
			get
			{
				return this._Mothers_Name;
			}
			set
			{
				if ((this._Mothers_Name != value))
				{
					this.OnMothers_NameChanging(value);
					this.SendPropertyChanging();
					this._Mothers_Name = value;
					this.SendPropertyChanged("Mothers_Name");
					this.OnMothers_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department_Id", DbType="Int")]
		public System.Nullable<int> Department_Id
		{
			get
			{
				return this._Department_Id;
			}
			set
			{
				if ((this._Department_Id != value))
				{
					if (this._Department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDepartment_IdChanging(value);
					this.SendPropertyChanging();
					this._Department_Id = value;
					this.SendPropertyChanged("Department_Id");
					this.OnDepartment_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Designation_Id", DbType="Int")]
		public System.Nullable<int> Designation_Id
		{
			get
			{
				return this._Designation_Id;
			}
			set
			{
				if ((this._Designation_Id != value))
				{
					if (this._Designation.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDesignation_IdChanging(value);
					this.SendPropertyChanging();
					this._Designation_Id = value;
					this.SendPropertyChanged("Designation_Id");
					this.OnDesignation_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobLocation_Id", DbType="Int")]
		public System.Nullable<int> JobLocation_Id
		{
			get
			{
				return this._JobLocation_Id;
			}
			set
			{
				if ((this._JobLocation_Id != value))
				{
					if (this._JobLocation.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnJobLocation_IdChanging(value);
					this.SendPropertyChanging();
					this._JobLocation_Id = value;
					this.SendPropertyChanged("JobLocation_Id");
					this.OnJobLocation_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Department", ThisKey="Department_Id", OtherKey="Id", IsForeignKey=true)]
		public Department Department
		{
			get
			{
				return this._Department.Entity;
			}
			set
			{
				Department previousValue = this._Department.Entity;
				if (((previousValue != value) 
							|| (this._Department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Department.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._Department.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._Department_Id = value.Id;
					}
					else
					{
						this._Department_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Department");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Designation_Employee", Storage="_Designation", ThisKey="Designation_Id", OtherKey="Id", IsForeignKey=true)]
		public Designation Designation
		{
			get
			{
				return this._Designation.Entity;
			}
			set
			{
				Designation previousValue = this._Designation.Entity;
				if (((previousValue != value) 
							|| (this._Designation.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Designation.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._Designation.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._Designation_Id = value.Id;
					}
					else
					{
						this._Designation_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Designation");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="JobLocation_Employee", Storage="_JobLocation", ThisKey="JobLocation_Id", OtherKey="Id", IsForeignKey=true)]
		public JobLocation JobLocation
		{
			get
			{
				return this._JobLocation.Entity;
			}
			set
			{
				JobLocation previousValue = this._JobLocation.Entity;
				if (((previousValue != value) 
							|| (this._JobLocation.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._JobLocation.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._JobLocation.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._JobLocation_Id = value.Id;
					}
					else
					{
						this._JobLocation_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("JobLocation");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.JobLocation")]
	public partial class JobLocation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _District_Name;
		
		private EntitySet<Employee> _Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDistrict_NameChanging(string value);
    partial void OnDistrict_NameChanged();
    #endregion
		
		public JobLocation()
		{
			this._Employees = new EntitySet<Employee>(new Action<Employee>(this.attach_Employees), new Action<Employee>(this.detach_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_District_Name", DbType="VarChar(50)")]
		public string District_Name
		{
			get
			{
				return this._District_Name;
			}
			set
			{
				if ((this._District_Name != value))
				{
					this.OnDistrict_NameChanging(value);
					this.SendPropertyChanging();
					this._District_Name = value;
					this.SendPropertyChanged("District_Name");
					this.OnDistrict_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="JobLocation_Employee", Storage="_Employees", ThisKey="Id", OtherKey="JobLocation_Id")]
		public EntitySet<Employee> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
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
		
		private void attach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.JobLocation = this;
		}
		
		private void detach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.JobLocation = null;
		}
	}
}
#pragma warning restore 1591
