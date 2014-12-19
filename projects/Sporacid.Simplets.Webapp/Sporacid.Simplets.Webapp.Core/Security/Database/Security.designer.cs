﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18331
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sporacid.Simplets.Webapp.Core.Security.Database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SIMPLETS")]
	public partial class SecurityDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertClaim(Claim instance);
    partial void UpdateClaim(Claim instance);
    partial void DeleteClaim(Claim instance);
    partial void InsertRoleTemplate(RoleTemplate instance);
    partial void UpdateRoleTemplate(RoleTemplate instance);
    partial void DeleteRoleTemplate(RoleTemplate instance);
    partial void InsertContext(Context instance);
    partial void UpdateContext(Context instance);
    partial void DeleteContext(Context instance);
    partial void InsertModule(Module instance);
    partial void UpdateModule(Module instance);
    partial void DeleteModule(Module instance);
    partial void InsertPrincipal(Principal instance);
    partial void UpdatePrincipal(Principal instance);
    partial void DeletePrincipal(Principal instance);
    partial void InsertPrincipalAudit(PrincipalAudit instance);
    partial void UpdatePrincipalAudit(PrincipalAudit instance);
    partial void DeletePrincipalAudit(PrincipalAudit instance);
    partial void InsertPrincipalModuleContextClaims(PrincipalModuleContextClaims instance);
    partial void UpdatePrincipalModuleContextClaims(PrincipalModuleContextClaims instance);
    partial void DeletePrincipalModuleContextClaims(PrincipalModuleContextClaims instance);
    partial void InsertRoleTemplateModuleClaims(RoleTemplateModuleClaims instance);
    partial void UpdateRoleTemplateModuleClaims(RoleTemplateModuleClaims instance);
    partial void DeleteRoleTemplateModuleClaims(RoleTemplateModuleClaims instance);
    #endregion
		
		public SecurityDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SecurityDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SecurityDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SecurityDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Claim> Claims
		{
			get
			{
				return this.GetTable<Claim>();
			}
		}
		
		public System.Data.Linq.Table<RoleTemplate> RoleTemplates
		{
			get
			{
				return this.GetTable<RoleTemplate>();
			}
		}
		
		public System.Data.Linq.Table<Context> Contexts
		{
			get
			{
				return this.GetTable<Context>();
			}
		}
		
		public System.Data.Linq.Table<Module> Modules
		{
			get
			{
				return this.GetTable<Module>();
			}
		}
		
		public System.Data.Linq.Table<Principal> Principals
		{
			get
			{
				return this.GetTable<Principal>();
			}
		}
		
		public System.Data.Linq.Table<PrincipalAudit> PrincipalAudits
		{
			get
			{
				return this.GetTable<PrincipalAudit>();
			}
		}
		
		public System.Data.Linq.Table<PrincipalModuleContextClaims> PrincipalModuleContextClaims
		{
			get
			{
				return this.GetTable<PrincipalModuleContextClaims>();
			}
		}
		
		public System.Data.Linq.Table<RoleTemplateModuleClaims> RoleTemplateModuleClaims
		{
			get
			{
				return this.GetTable<RoleTemplateModuleClaims>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="security.Claims")]
	public partial class Claim : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private int _Value;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnValueChanging(int value);
    partial void OnValueChanged();
    #endregion
		
		public Claim()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="Int NOT NULL")]
		public int Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="security.RolesTemplates")]
	public partial class RoleTemplate : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<RoleTemplateModuleClaims> _RoleTemplateModuleClaims;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public RoleTemplate()
		{
			this._RoleTemplateModuleClaims = new EntitySet<RoleTemplateModuleClaims>(new Action<RoleTemplateModuleClaims>(this.attach_RoleTemplateModuleClaims), new Action<RoleTemplateModuleClaims>(this.detach_RoleTemplateModuleClaims));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RoleTemplate_RoleTemplateModuleClaims", Storage="_RoleTemplateModuleClaims", ThisKey="Id", OtherKey="RoleTemplateId")]
		public EntitySet<RoleTemplateModuleClaims> RoleTemplateModuleClaims
		{
			get
			{
				return this._RoleTemplateModuleClaims;
			}
			set
			{
				this._RoleTemplateModuleClaims.Assign(value);
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
		
		private void attach_RoleTemplateModuleClaims(RoleTemplateModuleClaims entity)
		{
			this.SendPropertyChanging();
			entity.RoleTemplate = this;
		}
		
		private void detach_RoleTemplateModuleClaims(RoleTemplateModuleClaims entity)
		{
			this.SendPropertyChanging();
			entity.RoleTemplate = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="security.Contexts")]
	public partial class Context : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<PrincipalModuleContextClaims> _PrincipalModuleContextClaims;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Context()
		{
			this._PrincipalModuleContextClaims = new EntitySet<PrincipalModuleContextClaims>(new Action<PrincipalModuleContextClaims>(this.attach_PrincipalModuleContextClaims), new Action<PrincipalModuleContextClaims>(this.detach_PrincipalModuleContextClaims));
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Context_PrincipalModuleContextClaims", Storage="_PrincipalModuleContextClaims", ThisKey="Id", OtherKey="ContextId")]
		public EntitySet<PrincipalModuleContextClaims> PrincipalModuleContextClaims
		{
			get
			{
				return this._PrincipalModuleContextClaims;
			}
			set
			{
				this._PrincipalModuleContextClaims.Assign(value);
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
		
		private void attach_PrincipalModuleContextClaims(PrincipalModuleContextClaims entity)
		{
			this.SendPropertyChanging();
			entity.Context = this;
		}
		
		private void detach_PrincipalModuleContextClaims(PrincipalModuleContextClaims entity)
		{
			this.SendPropertyChanging();
			entity.Context = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="security.Modules")]
	public partial class Module : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<PrincipalModuleContextClaims> _PrincipalModuleContextClaims;
		
		private EntitySet<RoleTemplateModuleClaims> _RoleTemplateModuleClaims;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Module()
		{
			this._PrincipalModuleContextClaims = new EntitySet<PrincipalModuleContextClaims>(new Action<PrincipalModuleContextClaims>(this.attach_PrincipalModuleContextClaims), new Action<PrincipalModuleContextClaims>(this.detach_PrincipalModuleContextClaims));
			this._RoleTemplateModuleClaims = new EntitySet<RoleTemplateModuleClaims>(new Action<RoleTemplateModuleClaims>(this.attach_RoleTemplateModuleClaims), new Action<RoleTemplateModuleClaims>(this.detach_RoleTemplateModuleClaims));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Module_PrincipalModuleContextClaims", Storage="_PrincipalModuleContextClaims", ThisKey="Id", OtherKey="ModuleId")]
		public EntitySet<PrincipalModuleContextClaims> PrincipalModuleContextClaims
		{
			get
			{
				return this._PrincipalModuleContextClaims;
			}
			set
			{
				this._PrincipalModuleContextClaims.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Module_RoleTemplateModuleClaims", Storage="_RoleTemplateModuleClaims", ThisKey="Id", OtherKey="ModuleId")]
		public EntitySet<RoleTemplateModuleClaims> RoleTemplateModuleClaims
		{
			get
			{
				return this._RoleTemplateModuleClaims;
			}
			set
			{
				this._RoleTemplateModuleClaims.Assign(value);
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
		
		private void attach_PrincipalModuleContextClaims(PrincipalModuleContextClaims entity)
		{
			this.SendPropertyChanging();
			entity.Module = this;
		}
		
		private void detach_PrincipalModuleContextClaims(PrincipalModuleContextClaims entity)
		{
			this.SendPropertyChanging();
			entity.Module = null;
		}
		
		private void attach_RoleTemplateModuleClaims(RoleTemplateModuleClaims entity)
		{
			this.SendPropertyChanging();
			entity.Module = this;
		}
		
		private void detach_RoleTemplateModuleClaims(RoleTemplateModuleClaims entity)
		{
			this.SendPropertyChanging();
			entity.Module = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="security.Principals")]
	public partial class Principal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Identity;
		
		private EntitySet<PrincipalAudit> _PrincipalAudits;
		
		private EntitySet<PrincipalModuleContextClaims> _PrincipalModuleContextClaims;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnIdentityChanging(string value);
    partial void OnIdentityChanged();
    #endregion
		
		public Principal()
		{
			this._PrincipalAudits = new EntitySet<PrincipalAudit>(new Action<PrincipalAudit>(this.attach_PrincipalAudits), new Action<PrincipalAudit>(this.detach_PrincipalAudits));
			this._PrincipalModuleContextClaims = new EntitySet<PrincipalModuleContextClaims>(new Action<PrincipalModuleContextClaims>(this.attach_PrincipalModuleContextClaims), new Action<PrincipalModuleContextClaims>(this.detach_PrincipalModuleContextClaims));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Identity]", Storage="_Identity", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string Identity
		{
			get
			{
				return this._Identity;
			}
			set
			{
				if ((this._Identity != value))
				{
					this.OnIdentityChanging(value);
					this.SendPropertyChanging();
					this._Identity = value;
					this.SendPropertyChanged("Identity");
					this.OnIdentityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Principal_PrincipalAudit", Storage="_PrincipalAudits", ThisKey="Id", OtherKey="PrincipalId")]
		public EntitySet<PrincipalAudit> PrincipalAudits
		{
			get
			{
				return this._PrincipalAudits;
			}
			set
			{
				this._PrincipalAudits.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Principal_PrincipalModuleContextClaims", Storage="_PrincipalModuleContextClaims", ThisKey="Id", OtherKey="PrincipalId")]
		public EntitySet<PrincipalModuleContextClaims> PrincipalModuleContextClaims
		{
			get
			{
				return this._PrincipalModuleContextClaims;
			}
			set
			{
				this._PrincipalModuleContextClaims.Assign(value);
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
		
		private void attach_PrincipalAudits(PrincipalAudit entity)
		{
			this.SendPropertyChanging();
			entity.Principal = this;
		}
		
		private void detach_PrincipalAudits(PrincipalAudit entity)
		{
			this.SendPropertyChanging();
			entity.Principal = null;
		}
		
		private void attach_PrincipalModuleContextClaims(PrincipalModuleContextClaims entity)
		{
			this.SendPropertyChanging();
			entity.Principal = this;
		}
		
		private void detach_PrincipalModuleContextClaims(PrincipalModuleContextClaims entity)
		{
			this.SendPropertyChanging();
			entity.Principal = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="security.PrincipalsAudits")]
	public partial class PrincipalAudit : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private int _PrincipalId;
		
		private string _IpAddress;
		
		private System.DateTime _Date;
		
		private EntityRef<Principal> _Principal;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnPrincipalIdChanging(int value);
    partial void OnPrincipalIdChanged();
    partial void OnIpAddressChanging(string value);
    partial void OnIpAddressChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    #endregion
		
		public PrincipalAudit()
		{
			this._Principal = default(EntityRef<Principal>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrincipalId", DbType="Int NOT NULL")]
		public int PrincipalId
		{
			get
			{
				return this._PrincipalId;
			}
			set
			{
				if ((this._PrincipalId != value))
				{
					if (this._Principal.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPrincipalIdChanging(value);
					this.SendPropertyChanging();
					this._PrincipalId = value;
					this.SendPropertyChanged("PrincipalId");
					this.OnPrincipalIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IpAddress", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string IpAddress
		{
			get
			{
				return this._IpAddress;
			}
			set
			{
				if ((this._IpAddress != value))
				{
					this.OnIpAddressChanging(value);
					this.SendPropertyChanging();
					this._IpAddress = value;
					this.SendPropertyChanged("IpAddress");
					this.OnIpAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Principal_PrincipalAudit", Storage="_Principal", ThisKey="PrincipalId", OtherKey="Id", IsForeignKey=true)]
		public Principal Principal
		{
			get
			{
				return this._Principal.Entity;
			}
			set
			{
				Principal previousValue = this._Principal.Entity;
				if (((previousValue != value) 
							|| (this._Principal.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Principal.Entity = null;
						previousValue.PrincipalAudits.Remove(this);
					}
					this._Principal.Entity = value;
					if ((value != null))
					{
						value.PrincipalAudits.Add(this);
						this._PrincipalId = value.Id;
					}
					else
					{
						this._PrincipalId = default(int);
					}
					this.SendPropertyChanged("Principal");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="security.PrincipalsModulesContextsClaims")]
	public partial class PrincipalModuleContextClaims : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PrincipalId;
		
		private int _ModuleId;
		
		private int _ContextId;
		
		private int _Claims;
		
		private EntityRef<Context> _Context;
		
		private EntityRef<Principal> _Principal;
		
		private EntityRef<Module> _Module;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPrincipalIdChanging(int value);
    partial void OnPrincipalIdChanged();
    partial void OnModuleIdChanging(int value);
    partial void OnModuleIdChanged();
    partial void OnContextIdChanging(int value);
    partial void OnContextIdChanged();
    partial void OnClaimsChanging(int value);
    partial void OnClaimsChanged();
    #endregion
		
		public PrincipalModuleContextClaims()
		{
			this._Context = default(EntityRef<Context>);
			this._Principal = default(EntityRef<Principal>);
			this._Module = default(EntityRef<Module>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrincipalId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PrincipalId
		{
			get
			{
				return this._PrincipalId;
			}
			set
			{
				if ((this._PrincipalId != value))
				{
					if (this._Principal.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPrincipalIdChanging(value);
					this.SendPropertyChanging();
					this._PrincipalId = value;
					this.SendPropertyChanged("PrincipalId");
					this.OnPrincipalIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ModuleId
		{
			get
			{
				return this._ModuleId;
			}
			set
			{
				if ((this._ModuleId != value))
				{
					if (this._Module.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnModuleIdChanging(value);
					this.SendPropertyChanging();
					this._ModuleId = value;
					this.SendPropertyChanged("ModuleId");
					this.OnModuleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContextId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ContextId
		{
			get
			{
				return this._ContextId;
			}
			set
			{
				if ((this._ContextId != value))
				{
					if (this._Context.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnContextIdChanging(value);
					this.SendPropertyChanging();
					this._ContextId = value;
					this.SendPropertyChanged("ContextId");
					this.OnContextIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Claims", DbType="Int NOT NULL")]
		public int Claims
		{
			get
			{
				return this._Claims;
			}
			set
			{
				if ((this._Claims != value))
				{
					this.OnClaimsChanging(value);
					this.SendPropertyChanging();
					this._Claims = value;
					this.SendPropertyChanged("Claims");
					this.OnClaimsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Context_PrincipalModuleContextClaims", Storage="_Context", ThisKey="ContextId", OtherKey="Id", IsForeignKey=true)]
		public Context Context
		{
			get
			{
				return this._Context.Entity;
			}
			set
			{
				Context previousValue = this._Context.Entity;
				if (((previousValue != value) 
							|| (this._Context.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Context.Entity = null;
						previousValue.PrincipalModuleContextClaims.Remove(this);
					}
					this._Context.Entity = value;
					if ((value != null))
					{
						value.PrincipalModuleContextClaims.Add(this);
						this._ContextId = value.Id;
					}
					else
					{
						this._ContextId = default(int);
					}
					this.SendPropertyChanged("Context");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Principal_PrincipalModuleContextClaims", Storage="_Principal", ThisKey="PrincipalId", OtherKey="Id", IsForeignKey=true)]
		public Principal Principal
		{
			get
			{
				return this._Principal.Entity;
			}
			set
			{
				Principal previousValue = this._Principal.Entity;
				if (((previousValue != value) 
							|| (this._Principal.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Principal.Entity = null;
						previousValue.PrincipalModuleContextClaims.Remove(this);
					}
					this._Principal.Entity = value;
					if ((value != null))
					{
						value.PrincipalModuleContextClaims.Add(this);
						this._PrincipalId = value.Id;
					}
					else
					{
						this._PrincipalId = default(int);
					}
					this.SendPropertyChanged("Principal");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Module_PrincipalModuleContextClaims", Storage="_Module", ThisKey="ModuleId", OtherKey="Id", IsForeignKey=true)]
		public Module Module
		{
			get
			{
				return this._Module.Entity;
			}
			set
			{
				Module previousValue = this._Module.Entity;
				if (((previousValue != value) 
							|| (this._Module.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Module.Entity = null;
						previousValue.PrincipalModuleContextClaims.Remove(this);
					}
					this._Module.Entity = value;
					if ((value != null))
					{
						value.PrincipalModuleContextClaims.Add(this);
						this._ModuleId = value.Id;
					}
					else
					{
						this._ModuleId = default(int);
					}
					this.SendPropertyChanged("Module");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="security.RolesTemplatesModulesClaims")]
	public partial class RoleTemplateModuleClaims : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RoleTemplateId;
		
		private int _ModuleId;
		
		private int _Claims;
		
		private EntityRef<Module> _Module;
		
		private EntityRef<RoleTemplate> _RoleTemplate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRoleTemplateIdChanging(int value);
    partial void OnRoleTemplateIdChanged();
    partial void OnModuleIdChanging(int value);
    partial void OnModuleIdChanged();
    partial void OnClaimsChanging(int value);
    partial void OnClaimsChanged();
    #endregion
		
		public RoleTemplateModuleClaims()
		{
			this._Module = default(EntityRef<Module>);
			this._RoleTemplate = default(EntityRef<RoleTemplate>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleTemplateId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RoleTemplateId
		{
			get
			{
				return this._RoleTemplateId;
			}
			set
			{
				if ((this._RoleTemplateId != value))
				{
					if (this._RoleTemplate.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleTemplateIdChanging(value);
					this.SendPropertyChanging();
					this._RoleTemplateId = value;
					this.SendPropertyChanged("RoleTemplateId");
					this.OnRoleTemplateIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ModuleId
		{
			get
			{
				return this._ModuleId;
			}
			set
			{
				if ((this._ModuleId != value))
				{
					if (this._Module.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnModuleIdChanging(value);
					this.SendPropertyChanging();
					this._ModuleId = value;
					this.SendPropertyChanged("ModuleId");
					this.OnModuleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Claims", DbType="Int NOT NULL")]
		public int Claims
		{
			get
			{
				return this._Claims;
			}
			set
			{
				if ((this._Claims != value))
				{
					this.OnClaimsChanging(value);
					this.SendPropertyChanging();
					this._Claims = value;
					this.SendPropertyChanged("Claims");
					this.OnClaimsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Module_RoleTemplateModuleClaims", Storage="_Module", ThisKey="ModuleId", OtherKey="Id", IsForeignKey=true)]
		public Module Module
		{
			get
			{
				return this._Module.Entity;
			}
			set
			{
				Module previousValue = this._Module.Entity;
				if (((previousValue != value) 
							|| (this._Module.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Module.Entity = null;
						previousValue.RoleTemplateModuleClaims.Remove(this);
					}
					this._Module.Entity = value;
					if ((value != null))
					{
						value.RoleTemplateModuleClaims.Add(this);
						this._ModuleId = value.Id;
					}
					else
					{
						this._ModuleId = default(int);
					}
					this.SendPropertyChanged("Module");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RoleTemplate_RoleTemplateModuleClaims", Storage="_RoleTemplate", ThisKey="RoleTemplateId", OtherKey="Id", IsForeignKey=true)]
		public RoleTemplate RoleTemplate
		{
			get
			{
				return this._RoleTemplate.Entity;
			}
			set
			{
				RoleTemplate previousValue = this._RoleTemplate.Entity;
				if (((previousValue != value) 
							|| (this._RoleTemplate.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._RoleTemplate.Entity = null;
						previousValue.RoleTemplateModuleClaims.Remove(this);
					}
					this._RoleTemplate.Entity = value;
					if ((value != null))
					{
						value.RoleTemplateModuleClaims.Add(this);
						this._RoleTemplateId = value.Id;
					}
					else
					{
						this._RoleTemplateId = default(int);
					}
					this.SendPropertyChanged("RoleTemplate");
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
