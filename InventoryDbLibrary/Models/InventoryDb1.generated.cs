//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;
using LinqToDB.Mapping;

namespace Models
{
	/// <summary>
	/// Database       : Inventory
	/// Data Source    : Inventory
	/// Server Version : 3.19.3
	/// </summary>
	public partial class InventoryDB : LinqToDB.Data.DataConnection
	{
		public ITable<Client>          Clients          { get { return this.GetTable<Client>(); } }
		public ITable<ClientAccount>   ClientAccounts   { get { return this.GetTable<ClientAccount>(); } }
		public ITable<Farmer>          Farmers          { get { return this.GetTable<Farmer>(); } }
		public ITable<Good>            Goods            { get { return this.GetTable<Good>(); } }
		public ITable<GoodsBigUnit>    GoodsBigUnits    { get { return this.GetTable<GoodsBigUnit>(); } }
		public ITable<GoodsSmallUnit>  GoodsSmallUnits  { get { return this.GetTable<GoodsSmallUnit>(); } }
		public ITable<GoodsStyle>      GoodsStyles      { get { return this.GetTable<GoodsStyle>(); } }
		public ITable<Log>             Logs             { get { return this.GetTable<Log>(); } }
		public ITable<Purchase>        Purchases        { get { return this.GetTable<Purchase>(); } }
		public ITable<Retail>          Retails          { get { return this.GetTable<Retail>(); } }
		public ITable<Stock>           Stocks           { get { return this.GetTable<Stock>(); } }
		public ITable<Supplier>        Suppliers        { get { return this.GetTable<Supplier>(); } }
		public ITable<SupplierAccount> SupplierAccounts { get { return this.GetTable<SupplierAccount>(); } }
		public ITable<Wholesale>       Wholesales       { get { return this.GetTable<Wholesale>(); } }

		public void InitMappingSchema()
		{
		}

		public InventoryDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public InventoryDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext();
	}

	[Table("client")]
	public partial class Client
	{
		[Column("clientID"),      PrimaryKey,  Identity] public long   ClientID      { get; set; } // integer
		[Column("name"),          NotNull              ] public string Name          { get; set; } // text(max)
		[Column("phone"),            Nullable          ] public string Phone         { get; set; } // text(max)
		[Column("address"),          Nullable          ] public string Address       { get; set; } // text(max)
		[Column("storeName"),        Nullable          ] public string StoreName     { get; set; } // text(max)
		[Column("businessPlace"),    Nullable          ] public string BusinessPlace { get; set; } // text(max)
		[Column("storagePlace"),     Nullable          ] public string StoragePlace  { get; set; } // text(max)
		[Column("email"),            Nullable          ] public string Email         { get; set; } // text(max)
		[Column("creditCode"),       Nullable          ] public string CreditCode    { get; set; } // text(max)

		#region Associations

		/// <summary>
		/// FK_clientAccount_0_0_BackReference
		/// </summary>
		[Association(ThisKey="ClientID", OtherKey="ClientID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ClientAccount> ClientAccounts { get; set; }

		/// <summary>
		/// FK_wholesale_0_0_BackReference
		/// </summary>
		[Association(ThisKey="ClientID", OtherKey="ClientID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Wholesale> Wholesales { get; set; }

		#endregion
	}

	[Table("clientAccount")]
	public partial class ClientAccount
	{
		[Column("clientAccountID"), PrimaryKey, Identity] public long   ClientAccountID      { get; set; } // integer
		[Column("clientAccount"),   NotNull             ] public double ClientAccount_Column { get; set; } // real
		[Column("clientID"),        NotNull             ] public long   ClientID             { get; set; } // integer
		[Column("dataTime"),        NotNull             ] public string DataTime             { get; set; } // text(max)

		#region Associations

		/// <summary>
		/// FK_clientAccount_0_0
		/// </summary>
		[Association(ThisKey="ClientID", OtherKey="ClientID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_clientAccount_0_0", BackReferenceName="ClientAccounts")]
		public Client Client { get; set; }

		#endregion
	}

	[Table("farmer")]
	public partial class Farmer
	{
		[Column("farmerID"), PrimaryKey, Identity] public long   FarmerID { get; set; } // integer
		[Column("name"),     Nullable            ] public string Name     { get; set; } // text(max)
		[Column("phone"),    Nullable            ] public string Phone    { get; set; } // text(max)
		[Column("number"),   Nullable            ] public string Number   { get; set; } // text(max)
		[Column("province"), Nullable            ] public string Province { get; set; } // text(max)
		[Column("city"),     Nullable            ] public string City     { get; set; } // text(max)
		[Column("county"),   Nullable            ] public string County   { get; set; } // text(max)
		[Column("town"),     Nullable            ] public string Town     { get; set; } // text(max)
		[Column("village"),  Nullable            ] public string Village  { get; set; } // text(max)

		#region Associations

		/// <summary>
		/// FK_retail_0_0_BackReference
		/// </summary>
		[Association(ThisKey="FarmerID", OtherKey="FarmerID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Retail> Retails { get; set; }

		#endregion
	}

	[Table("goods")]
	public partial class Good
	{
		[Column("goodsID"),             PrimaryKey,  Identity] public long    GoodsID             { get; set; } // integer
		[Column("name"),                NotNull              ] public string  Name                { get; set; } // text(max)
		[Column("style"),               NotNull              ] public string  Style               { get; set; } // text(max)
		[Column("isHighToxicity"),      NotNull              ] public long    IsHighToxicity      { get; set; } // integer
		[Column("bigUnit"),             NotNull              ] public string  BigUnit             { get; set; } // text(max)
		[Column("content"),             NotNull              ] public long    Content             { get; set; } // integer
		[Column("identificationCode"),  NotNull              ] public string  IdentificationCode  { get; set; } // text(max)
		[Column("smallUnit"),           NotNull              ] public string  SmallUnit           { get; set; } // text(max)
		[Column("styleBig"),            NotNull              ] public string  StyleBig            { get; set; } // text(max)
		[Column("mainIngredient"),         Nullable          ] public string  MainIngredient      { get; set; } // text(max)
		[Column("boxWeight"),              Nullable          ] public double? BoxWeight           { get; set; } // real
		[Column("bottleWeight"),           Nullable          ] public double? BottleWeight        { get; set; } // real
		[Column("manufacturer"),           Nullable          ] public string  Manufacturer        { get; set; } // text(max)
		[Column("registrationCode"),       Nullable          ] public string  RegistrationCode    { get; set; } // text(max)
		[Column("purchaseReferPrice"),     Nullable          ] public double? PurchaseReferPrice  { get; set; } // real
		[Column("wholesaleReferPrice"),    Nullable          ] public double? WholesaleReferPrice { get; set; } // real
		[Column("retailReferPrice"),       Nullable          ] public double? RetailReferPrice    { get; set; } // real

		#region Associations

		/// <summary>
		/// FK_goods_1_0
		/// </summary>
		[Association(ThisKey="BigUnit", OtherKey="BigUnit", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_goods_1_0", BackReferenceName="Goods")]
		public GoodsBigUnit GoodsBigUnit { get; set; }

		/// <summary>
		/// FK_goods_0_0
		/// </summary>
		[Association(ThisKey="SmallUnit", OtherKey="SmallUnit", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_goods_0_0", BackReferenceName="Goods")]
		public GoodsSmallUnit GoodsSmallUnit { get; set; }

		/// <summary>
		/// FK_goods_2_0
		/// </summary>
		[Association(ThisKey="Style", OtherKey="Style", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_goods_2_0", BackReferenceName="Goods")]
		public GoodsStyle GoodsStyle { get; set; }

		/// <summary>
		/// FK_purchase_1_0_BackReference
		/// </summary>
		[Association(ThisKey="GoodsID", OtherKey="GoodsID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Purchase> Purchases { get; set; }

		/// <summary>
		/// FK_retail_1_0_BackReference
		/// </summary>
		[Association(ThisKey="GoodsID", OtherKey="GoodsID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Retail> Retails { get; set; }

		/// <summary>
		/// FK_stock_0_0_BackReference
		/// </summary>
		[Association(ThisKey="GoodsID", OtherKey="GoodsID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Stock> Stocks { get; set; }

		/// <summary>
		/// FK_wholesale_1_0_BackReference
		/// </summary>
		[Association(ThisKey="GoodsID", OtherKey="GoodsID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Wholesale> Wholesales { get; set; }

		#endregion
	}

	[Table("goodsBigUnit")]
	public partial class GoodsBigUnit
	{
		[Column("bigUnit"), PrimaryKey, NotNull] public string BigUnit { get; set; } // text(max)

		#region Associations

		/// <summary>
		/// FK_goods_1_0_BackReference
		/// </summary>
		[Association(ThisKey="BigUnit", OtherKey="BigUnit", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Good> Goods { get; set; }

		#endregion
	}

	[Table("goodsSmallUnit")]
	public partial class GoodsSmallUnit
	{
		[Column("smallUnit"), PrimaryKey, NotNull] public string SmallUnit { get; set; } // text(max)

		#region Associations

		/// <summary>
		/// FK_goods_0_0_BackReference
		/// </summary>
		[Association(ThisKey="SmallUnit", OtherKey="SmallUnit", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Good> Goods { get; set; }

		#endregion
	}

	[Table("goodsStyle")]
	public partial class GoodsStyle
	{
		[Column("style"),    PrimaryKey, NotNull] public string Style    { get; set; } // text(max)
		[Column("styleBig"),             NotNull] public string StyleBig { get; set; } // text(max)

		#region Associations

		/// <summary>
		/// FK_goods_2_0_BackReference
		/// </summary>
		[Association(ThisKey="Style", OtherKey="Style", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Good> Goods { get; set; }

		#endregion
	}

	[Table("log")]
	public partial class Log
	{
		[Column("logID"),       PrimaryKey, NotNull] public long   LogID       { get; set; } // integer
		[Column("logContent"),              NotNull] public string LogContent  { get; set; } // text(max)
		[Column("logDateTime"),             NotNull] public string LogDateTime { get; set; } // text(max)
		[Column("logAction"),               NotNull] public string LogAction   { get; set; } // text(max)
	}

	[Table("purchase")]
	public partial class Purchase
	{
		[Column("purchaseID"), PrimaryKey, Identity] public long   PurchaseID   { get; set; } // integer
		[Column("code"),       NotNull             ] public string Code         { get; set; } // text(max)
		[Column("datatime"),   NotNull             ] public string Datatime     { get; set; } // text(max)
		[Column("masterName"), NotNull             ] public string MasterName   { get; set; } // text(max)
		[Column("goodsID"),    NotNull             ] public long   GoodsID      { get; set; } // integer
		[Column(),             NotNull             ] public double RealPrice    { get; set; } // real
		[Column(),             NotNull             ] public double NumBigUnit   { get; set; } // real
		[Column(),             NotNull             ] public long   NumSmallUnit { get; set; } // integer
		[Column(),             NotNull             ] public double SumPrice     { get; set; } // real
		[Column("isReturn"),   NotNull             ] public long   IsReturn     { get; set; } // integer
		[Column("supplierID"), NotNull             ] public long   SupplierID   { get; set; } // integer

		#region Associations

		/// <summary>
		/// FK_purchase_1_0
		/// </summary>
		[Association(ThisKey="GoodsID", OtherKey="GoodsID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_purchase_1_0", BackReferenceName="Purchases")]
		public Good Good { get; set; }

		/// <summary>
		/// FK_purchase_0_0
		/// </summary>
		[Association(ThisKey="SupplierID", OtherKey="SupplierID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_purchase_0_0", BackReferenceName="Purchases")]
		public Supplier Supplier { get; set; }

		#endregion
	}

	[Table("retail")]
	public partial class Retail
	{
		[Column("retailID"),   PrimaryKey, Identity] public long   RetailID     { get; set; } // integer
		[Column("code"),       NotNull             ] public string Code         { get; set; } // text(max)
		[Column("datatime"),   NotNull             ] public string Datatime     { get; set; } // text(max)
		[Column("masterName"), NotNull             ] public string MasterName   { get; set; } // text(max)
		[Column("goodsID"),    NotNull             ] public long   GoodsID      { get; set; } // integer
		[Column(),             NotNull             ] public double RealPrice    { get; set; } // real
		[Column(),             NotNull             ] public double NumBigUnit   { get; set; } // real
		[Column(),             NotNull             ] public long   NumSmallUnit { get; set; } // integer
		[Column(),             NotNull             ] public double SumPrice     { get; set; } // real
		[Column("isReturn"),   NotNull             ] public long   IsReturn     { get; set; } // integer
		[Column("farmerID"),   NotNull             ] public long   FarmerID     { get; set; } // integer

		#region Associations

		/// <summary>
		/// FK_retail_0_0
		/// </summary>
		[Association(ThisKey="FarmerID", OtherKey="FarmerID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_retail_0_0", BackReferenceName="Retails")]
		public Farmer Farmer { get; set; }

		/// <summary>
		/// FK_retail_1_0
		/// </summary>
		[Association(ThisKey="GoodsID", OtherKey="GoodsID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_retail_1_0", BackReferenceName="Retails")]
		public Good Good { get; set; }

		#endregion
	}

	[Table("stock")]
	public partial class Stock
	{
		[Column("stockID"),    PrimaryKey, Identity] public long   StockID      { get; set; } // integer
		[Column("masterName"), NotNull             ] public string MasterName   { get; set; } // text(max)
		[Column("goodsID"),    NotNull             ] public long   GoodsID      { get; set; } // integer
		[Column(),             NotNull             ] public double NumBigUnit   { get; set; } // real
		[Column(),             NotNull             ] public long   NumSmallUnit { get; set; } // integer

		#region Associations

		/// <summary>
		/// FK_stock_0_0
		/// </summary>
		[Association(ThisKey="GoodsID", OtherKey="GoodsID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_stock_0_0", BackReferenceName="Stocks")]
		public Good Good { get; set; }

		#endregion
	}

	[Table("supplier")]
	public partial class Supplier
	{
		[Column("supplierID"), PrimaryKey,  Identity] public long   SupplierID      { get; set; } // integer
		[Column("supplier"),   NotNull              ] public string Supplier_Column { get; set; } // text(max)
		[Column("contact"),    NotNull              ] public string Contact         { get; set; } // text(max)
		[Column("phone"),         Nullable          ] public string Phone           { get; set; } // text(max)
		[Column("fax"),           Nullable          ] public string Fax             { get; set; } // text(max)
		[Column("email"),         Nullable          ] public string Email           { get; set; } // text(max)
		[Column("address"),       Nullable          ] public string Address         { get; set; } // text(max)
		[Column("nature"),        Nullable          ] public string Nature          { get; set; } // text(max)
		[Column("legal"),         Nullable          ] public string Legal           { get; set; } // text(max)
		[Column("bank"),          Nullable          ] public string Bank            { get; set; } // text(max)
		[Column("bankAccout"),    Nullable          ] public string BankAccout      { get; set; } // text(max)
		[Column("remarks"),       Nullable          ] public string Remarks         { get; set; } // text(max)

		#region Associations

		/// <summary>
		/// FK_purchase_0_0_BackReference
		/// </summary>
		[Association(ThisKey="SupplierID", OtherKey="SupplierID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<Purchase> Purchases { get; set; }

		/// <summary>
		/// FK_supplierAccount_0_0_BackReference
		/// </summary>
		[Association(ThisKey="SupplierID", OtherKey="SupplierID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<SupplierAccount> SupplierAccounts { get; set; }

		#endregion
	}

	[Table("supplierAccount")]
	public partial class SupplierAccount
	{
		[Column("supplierAccountID"), PrimaryKey,  Identity] public long    SupplierAccountID      { get; set; } // integer
		[Column("supplierID"),        NotNull              ] public long    SupplierID             { get; set; } // integer
		[Column("datetime"),             Nullable          ] public string  Datetime               { get; set; } // text(max)
		[Column("supplierAccount"),      Nullable          ] public double? SupplierAccount_Column { get; set; } // real

		#region Associations

		/// <summary>
		/// FK_supplierAccount_0_0
		/// </summary>
		[Association(ThisKey="SupplierID", OtherKey="SupplierID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_supplierAccount_0_0", BackReferenceName="SupplierAccounts")]
		public Supplier Supplier { get; set; }

		#endregion
	}

	[Table("wholesale")]
	public partial class Wholesale
	{
		[Column("wholesaleID"), PrimaryKey, Identity] public long   WholesaleID  { get; set; } // integer
		[Column("code"),        NotNull             ] public string Code         { get; set; } // text(max)
		[Column("datatime"),    NotNull             ] public string Datatime     { get; set; } // text(max)
		[Column("masterName"),  NotNull             ] public string MasterName   { get; set; } // text(max)
		[Column("goodsID"),     NotNull             ] public long   GoodsID      { get; set; } // integer
		[Column(),              NotNull             ] public double RealPrice    { get; set; } // real
		[Column(),              NotNull             ] public double NumBigUnit   { get; set; } // real
		[Column(),              NotNull             ] public long   NumSmallUnit { get; set; } // integer
		[Column(),              NotNull             ] public double SumPrice     { get; set; } // real
		[Column("isReturn"),    NotNull             ] public long   IsReturn     { get; set; } // integer
		[Column("clientID"),    NotNull             ] public long   ClientID     { get; set; } // integer

		#region Associations

		/// <summary>
		/// FK_wholesale_0_0
		/// </summary>
		[Association(ThisKey="ClientID", OtherKey="ClientID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_wholesale_0_0", BackReferenceName="Wholesales")]
		public Client Client { get; set; }

		/// <summary>
		/// FK_wholesale_1_0
		/// </summary>
		[Association(ThisKey="GoodsID", OtherKey="GoodsID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_wholesale_1_0", BackReferenceName="Wholesales")]
		public Good Good { get; set; }

		#endregion
	}

	public static partial class TableExtensions
	{
		public static Client Find(this ITable<Client> table, long ClientID)
		{
			return table.FirstOrDefault(t =>
				t.ClientID == ClientID);
		}

		public static ClientAccount Find(this ITable<ClientAccount> table, long ClientAccountID)
		{
			return table.FirstOrDefault(t =>
				t.ClientAccountID == ClientAccountID);
		}

		public static Farmer Find(this ITable<Farmer> table, long FarmerID)
		{
			return table.FirstOrDefault(t =>
				t.FarmerID == FarmerID);
		}

		public static Good Find(this ITable<Good> table, long GoodsID)
		{
			return table.FirstOrDefault(t =>
				t.GoodsID == GoodsID);
		}

		public static GoodsBigUnit Find(this ITable<GoodsBigUnit> table, string BigUnit)
		{
			return table.FirstOrDefault(t =>
				t.BigUnit == BigUnit);
		}

		public static GoodsSmallUnit Find(this ITable<GoodsSmallUnit> table, string SmallUnit)
		{
			return table.FirstOrDefault(t =>
				t.SmallUnit == SmallUnit);
		}

		public static GoodsStyle Find(this ITable<GoodsStyle> table, string Style)
		{
			return table.FirstOrDefault(t =>
				t.Style == Style);
		}

		public static Log Find(this ITable<Log> table, long LogID)
		{
			return table.FirstOrDefault(t =>
				t.LogID == LogID);
		}

		public static Purchase Find(this ITable<Purchase> table, long PurchaseID)
		{
			return table.FirstOrDefault(t =>
				t.PurchaseID == PurchaseID);
		}

		public static Retail Find(this ITable<Retail> table, long RetailID)
		{
			return table.FirstOrDefault(t =>
				t.RetailID == RetailID);
		}

		public static Stock Find(this ITable<Stock> table, long StockID)
		{
			return table.FirstOrDefault(t =>
				t.StockID == StockID);
		}

		public static Supplier Find(this ITable<Supplier> table, long SupplierID)
		{
			return table.FirstOrDefault(t =>
				t.SupplierID == SupplierID);
		}

		public static SupplierAccount Find(this ITable<SupplierAccount> table, long SupplierAccountID)
		{
			return table.FirstOrDefault(t =>
				t.SupplierAccountID == SupplierAccountID);
		}

		public static Wholesale Find(this ITable<Wholesale> table, long WholesaleID)
		{
			return table.FirstOrDefault(t =>
				t.WholesaleID == WholesaleID);
		}
	}
}