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

namespace QLSV.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLSV")]
	public partial class QLSVDatabaseContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKetQua(KetQua instance);
    partial void UpdateKetQua(KetQua instance);
    partial void DeleteKetQua(KetQua instance);
    partial void InsertKhoa(Khoa instance);
    partial void UpdateKhoa(Khoa instance);
    partial void DeleteKhoa(Khoa instance);
    partial void InsertMonHoc(MonHoc instance);
    partial void UpdateMonHoc(MonHoc instance);
    partial void DeleteMonHoc(MonHoc instance);
    partial void InsertSinhVien(SinhVien instance);
    partial void UpdateSinhVien(SinhVien instance);
    partial void DeleteSinhVien(SinhVien instance);
    partial void InsertLop(Lop instance);
    partial void UpdateLop(Lop instance);
    partial void DeleteLop(Lop instance);
    #endregion
		
		public QLSVDatabaseContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLSVConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLSVDatabaseContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSVDatabaseContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSVDatabaseContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSVDatabaseContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KetQua> KetQuas
		{
			get
			{
				return this.GetTable<KetQua>();
			}
		}
		
		public System.Data.Linq.Table<Khoa> Khoas
		{
			get
			{
				return this.GetTable<Khoa>();
			}
		}
		
		public System.Data.Linq.Table<MonHoc> MonHocs
		{
			get
			{
				return this.GetTable<MonHoc>();
			}
		}
		
		public System.Data.Linq.Table<SinhVien> SinhViens
		{
			get
			{
				return this.GetTable<SinhVien>();
			}
		}
		
		public System.Data.Linq.Table<Lop> Lops
		{
			get
			{
				return this.GetTable<Lop>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KetQua")]
	public partial class KetQua : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSV;
		
		private string _MaMH;
		
		private System.Nullable<double> _DiemThi;
		
		private EntityRef<MonHoc> _MonHoc;
		
		private EntityRef<SinhVien> _SinhVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSVChanging(int value);
    partial void OnMaSVChanged();
    partial void OnMaMHChanging(string value);
    partial void OnMaMHChanged();
    partial void OnDiemThiChanging(System.Nullable<double> value);
    partial void OnDiemThiChanged();
    #endregion
		
		public KetQua()
		{
			this._MonHoc = default(EntityRef<MonHoc>);
			this._SinhVien = default(EntityRef<SinhVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					if (this._SinhVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSVChanging(value);
					this.SendPropertyChanging();
					this._MaSV = value;
					this.SendPropertyChanged("MaSV");
					this.OnMaSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMH", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaMH
		{
			get
			{
				return this._MaMH;
			}
			set
			{
				if ((this._MaMH != value))
				{
					if (this._MonHoc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaMHChanging(value);
					this.SendPropertyChanging();
					this._MaMH = value;
					this.SendPropertyChanged("MaMH");
					this.OnMaMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemThi", DbType="Float")]
		public System.Nullable<double> DiemThi
		{
			get
			{
				return this._DiemThi;
			}
			set
			{
				if ((this._DiemThi != value))
				{
					this.OnDiemThiChanging(value);
					this.SendPropertyChanging();
					this._DiemThi = value;
					this.SendPropertyChanged("DiemThi");
					this.OnDiemThiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MonHoc_KetQua", Storage="_MonHoc", ThisKey="MaMH", OtherKey="MaMH", IsForeignKey=true)]
		public MonHoc MonHoc
		{
			get
			{
				return this._MonHoc.Entity;
			}
			set
			{
				MonHoc previousValue = this._MonHoc.Entity;
				if (((previousValue != value) 
							|| (this._MonHoc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MonHoc.Entity = null;
						previousValue.KetQuas.Remove(this);
					}
					this._MonHoc.Entity = value;
					if ((value != null))
					{
						value.KetQuas.Add(this);
						this._MaMH = value.MaMH;
					}
					else
					{
						this._MaMH = default(string);
					}
					this.SendPropertyChanged("MonHoc");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SinhVien_KetQua", Storage="_SinhVien", ThisKey="MaSV", OtherKey="MaSV", IsForeignKey=true)]
		public SinhVien SinhVien
		{
			get
			{
				return this._SinhVien.Entity;
			}
			set
			{
				SinhVien previousValue = this._SinhVien.Entity;
				if (((previousValue != value) 
							|| (this._SinhVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SinhVien.Entity = null;
						previousValue.KetQuas.Remove(this);
					}
					this._SinhVien.Entity = value;
					if ((value != null))
					{
						value.KetQuas.Add(this);
						this._MaSV = value.MaSV;
					}
					else
					{
						this._MaSV = default(int);
					}
					this.SendPropertyChanged("SinhVien");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Khoa")]
	public partial class Khoa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKhoa;
		
		private string _TenKhoa;
		
		private System.Nullable<int> _SoCBGD;
		
		private EntitySet<Lop> _Lops;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhoaChanging(int value);
    partial void OnMaKhoaChanged();
    partial void OnTenKhoaChanging(string value);
    partial void OnTenKhoaChanged();
    partial void OnSoCBGDChanging(System.Nullable<int> value);
    partial void OnSoCBGDChanged();
    #endregion
		
		public Khoa()
		{
			this._Lops = new EntitySet<Lop>(new Action<Lop>(this.attach_Lops), new Action<Lop>(this.detach_Lops));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoa", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaKhoa
		{
			get
			{
				return this._MaKhoa;
			}
			set
			{
				if ((this._MaKhoa != value))
				{
					this.OnMaKhoaChanging(value);
					this.SendPropertyChanging();
					this._MaKhoa = value;
					this.SendPropertyChanged("MaKhoa");
					this.OnMaKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhoa", DbType="NVarChar(50)")]
		public string TenKhoa
		{
			get
			{
				return this._TenKhoa;
			}
			set
			{
				if ((this._TenKhoa != value))
				{
					this.OnTenKhoaChanging(value);
					this.SendPropertyChanging();
					this._TenKhoa = value;
					this.SendPropertyChanged("TenKhoa");
					this.OnTenKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoCBGD", DbType="Int")]
		public System.Nullable<int> SoCBGD
		{
			get
			{
				return this._SoCBGD;
			}
			set
			{
				if ((this._SoCBGD != value))
				{
					this.OnSoCBGDChanging(value);
					this.SendPropertyChanging();
					this._SoCBGD = value;
					this.SendPropertyChanged("SoCBGD");
					this.OnSoCBGDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Khoa_Lop", Storage="_Lops", ThisKey="MaKhoa", OtherKey="MaKhoa")]
		public EntitySet<Lop> Lops
		{
			get
			{
				return this._Lops;
			}
			set
			{
				this._Lops.Assign(value);
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
		
		private void attach_Lops(Lop entity)
		{
			this.SendPropertyChanging();
			entity.Khoa = this;
		}
		
		private void detach_Lops(Lop entity)
		{
			this.SendPropertyChanging();
			entity.Khoa = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MonHoc")]
	public partial class MonHoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaMH;
		
		private string _TenMH;
		
		private System.Nullable<int> _SoTiet;
		
		private EntitySet<KetQua> _KetQuas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaMHChanging(string value);
    partial void OnMaMHChanged();
    partial void OnTenMHChanging(string value);
    partial void OnTenMHChanged();
    partial void OnSoTietChanging(System.Nullable<int> value);
    partial void OnSoTietChanged();
    #endregion
		
		public MonHoc()
		{
			this._KetQuas = new EntitySet<KetQua>(new Action<KetQua>(this.attach_KetQuas), new Action<KetQua>(this.detach_KetQuas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMH", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaMH
		{
			get
			{
				return this._MaMH;
			}
			set
			{
				if ((this._MaMH != value))
				{
					this.OnMaMHChanging(value);
					this.SendPropertyChanging();
					this._MaMH = value;
					this.SendPropertyChanged("MaMH");
					this.OnMaMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMH", DbType="NVarChar(50)")]
		public string TenMH
		{
			get
			{
				return this._TenMH;
			}
			set
			{
				if ((this._TenMH != value))
				{
					this.OnTenMHChanging(value);
					this.SendPropertyChanging();
					this._TenMH = value;
					this.SendPropertyChanged("TenMH");
					this.OnTenMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTiet", DbType="Int")]
		public System.Nullable<int> SoTiet
		{
			get
			{
				return this._SoTiet;
			}
			set
			{
				if ((this._SoTiet != value))
				{
					this.OnSoTietChanging(value);
					this.SendPropertyChanging();
					this._SoTiet = value;
					this.SendPropertyChanged("SoTiet");
					this.OnSoTietChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MonHoc_KetQua", Storage="_KetQuas", ThisKey="MaMH", OtherKey="MaMH")]
		public EntitySet<KetQua> KetQuas
		{
			get
			{
				return this._KetQuas;
			}
			set
			{
				this._KetQuas.Assign(value);
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
		
		private void attach_KetQuas(KetQua entity)
		{
			this.SendPropertyChanging();
			entity.MonHoc = this;
		}
		
		private void detach_KetQuas(KetQua entity)
		{
			this.SendPropertyChanging();
			entity.MonHoc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SinhVien")]
	public partial class SinhVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSV;
		
		private string _HoTen;
		
		private string _Nu;
		
		private string _GioiTinh;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _MaLop;
		
		private System.Nullable<bool> _HocBong;
		
		private string _Tinh;
		
		private EntitySet<KetQua> _KetQuas;
		
		private EntityRef<Lop> _Lop;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSVChanging(int value);
    partial void OnMaSVChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnNuChanging(string value);
    partial void OnNuChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnMaLopChanging(string value);
    partial void OnMaLopChanged();
    partial void OnHocBongChanging(System.Nullable<bool> value);
    partial void OnHocBongChanged();
    partial void OnTinhChanging(string value);
    partial void OnTinhChanged();
    #endregion
		
		public SinhVien()
		{
			this._KetQuas = new EntitySet<KetQua>(new Action<KetQua>(this.attach_KetQuas), new Action<KetQua>(this.detach_KetQuas));
			this._Lop = default(EntityRef<Lop>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this.OnMaSVChanging(value);
					this.SendPropertyChanging();
					this._MaSV = value;
					this.SendPropertyChanged("MaSV");
					this.OnMaSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nu", DbType="NVarChar(50)")]
		public string Nu
		{
			get
			{
				return this._Nu;
			}
			set
			{
				if ((this._Nu != value))
				{
					this.OnNuChanging(value);
					this.SendPropertyChanging();
					this._Nu = value;
					this.SendPropertyChanged("Nu");
					this.OnNuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NChar(10)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(50)")]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					if (this._Lop.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HocBong", DbType="Bit")]
		public System.Nullable<bool> HocBong
		{
			get
			{
				return this._HocBong;
			}
			set
			{
				if ((this._HocBong != value))
				{
					this.OnHocBongChanging(value);
					this.SendPropertyChanging();
					this._HocBong = value;
					this.SendPropertyChanged("HocBong");
					this.OnHocBongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tinh", DbType="NVarChar(50)")]
		public string Tinh
		{
			get
			{
				return this._Tinh;
			}
			set
			{
				if ((this._Tinh != value))
				{
					this.OnTinhChanging(value);
					this.SendPropertyChanging();
					this._Tinh = value;
					this.SendPropertyChanged("Tinh");
					this.OnTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SinhVien_KetQua", Storage="_KetQuas", ThisKey="MaSV", OtherKey="MaSV")]
		public EntitySet<KetQua> KetQuas
		{
			get
			{
				return this._KetQuas;
			}
			set
			{
				this._KetQuas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lop_SinhVien", Storage="_Lop", ThisKey="MaLop", OtherKey="MaLop", IsForeignKey=true)]
		public Lop Lop
		{
			get
			{
				return this._Lop.Entity;
			}
			set
			{
				Lop previousValue = this._Lop.Entity;
				if (((previousValue != value) 
							|| (this._Lop.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Lop.Entity = null;
						previousValue.SinhViens.Remove(this);
					}
					this._Lop.Entity = value;
					if ((value != null))
					{
						value.SinhViens.Add(this);
						this._MaLop = value.MaLop;
					}
					else
					{
						this._MaLop = default(string);
					}
					this.SendPropertyChanged("Lop");
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
		
		private void attach_KetQuas(KetQua entity)
		{
			this.SendPropertyChanging();
			entity.SinhVien = this;
		}
		
		private void detach_KetQuas(KetQua entity)
		{
			this.SendPropertyChanging();
			entity.SinhVien = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lop")]
	public partial class Lop : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaLop;
		
		private string _TenLop;
		
		private System.Nullable<int> _MaKhoa;
		
		private EntitySet<SinhVien> _SinhViens;
		
		private EntityRef<Khoa> _Khoa;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLopChanging(string value);
    partial void OnMaLopChanged();
    partial void OnTenLopChanging(string value);
    partial void OnTenLopChanged();
    partial void OnMaKhoaChanging(System.Nullable<int> value);
    partial void OnMaKhoaChanged();
    #endregion
		
		public Lop()
		{
			this._SinhViens = new EntitySet<SinhVien>(new Action<SinhVien>(this.attach_SinhViens), new Action<SinhVien>(this.detach_SinhViens));
			this._Khoa = default(EntityRef<Khoa>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLop", DbType="NVarChar(50)")]
		public string TenLop
		{
			get
			{
				return this._TenLop;
			}
			set
			{
				if ((this._TenLop != value))
				{
					this.OnTenLopChanging(value);
					this.SendPropertyChanging();
					this._TenLop = value;
					this.SendPropertyChanged("TenLop");
					this.OnTenLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoa", DbType="Int")]
		public System.Nullable<int> MaKhoa
		{
			get
			{
				return this._MaKhoa;
			}
			set
			{
				if ((this._MaKhoa != value))
				{
					if (this._Khoa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhoaChanging(value);
					this.SendPropertyChanging();
					this._MaKhoa = value;
					this.SendPropertyChanged("MaKhoa");
					this.OnMaKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lop_SinhVien", Storage="_SinhViens", ThisKey="MaLop", OtherKey="MaLop")]
		public EntitySet<SinhVien> SinhViens
		{
			get
			{
				return this._SinhViens;
			}
			set
			{
				this._SinhViens.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Khoa_Lop", Storage="_Khoa", ThisKey="MaKhoa", OtherKey="MaKhoa", IsForeignKey=true)]
		public Khoa Khoa
		{
			get
			{
				return this._Khoa.Entity;
			}
			set
			{
				Khoa previousValue = this._Khoa.Entity;
				if (((previousValue != value) 
							|| (this._Khoa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Khoa.Entity = null;
						previousValue.Lops.Remove(this);
					}
					this._Khoa.Entity = value;
					if ((value != null))
					{
						value.Lops.Add(this);
						this._MaKhoa = value.MaKhoa;
					}
					else
					{
						this._MaKhoa = default(Nullable<int>);
					}
					this.SendPropertyChanged("Khoa");
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
		
		private void attach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.Lop = this;
		}
		
		private void detach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.Lop = null;
		}
	}
}
#pragma warning restore 1591
