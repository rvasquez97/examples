#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JHM.SharedService.D365.D365Model.Entities
{
	
	
	/// <summary>
	/// Type of product Classification.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum product_productstructure
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Product = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		ProductFamily = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		ProductBundle = 3,
	}
	
	/// <summary>
	/// Type of product.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum product_producttypecode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		ProductSales = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Donation = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		RecurringDonation = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		MiscellaneousCharges = 4,
	}
	
	/// <summary>
	/// Status of the product.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum product_statecode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Draft = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		UnderRevision = 3,
	}
	
	/// <summary>
	/// Reason for the status of the product.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum product_statuscode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Retired = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Draft = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		UnderRevision = 3,
	}
	
	/// <summary>
	/// Information about products and their pricing information.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("product")]
	public partial class Product : Microsoft.Xrm.Sdk.Entity
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Product() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "product";
		
		public const string EntityLogicalCollectionName = "products";
		
		public const string EntitySetName = "products";
		
		/// <summary>
		/// Unique identifier of the user who created the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Shows the external party who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Current cost for the product item. Used in price calculations.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentcost")]
		public Microsoft.Xrm.Sdk.Money CurrentCost
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("currentcost");
			}
			set
			{
				this.SetAttributeValue("currentcost", value);
			}
		}
		
		/// <summary>
		/// Value of the Current Cost in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentcost_base")]
		public Microsoft.Xrm.Sdk.Money CurrentCost_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("currentcost_base");
			}
		}
		
		/// <summary>
		/// Default unit for the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultuomid")]
		public Microsoft.Xrm.Sdk.EntityReference DefaultUoMId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultuomid");
			}
			set
			{
				this.SetAttributeValue("defaultuomid", value);
			}
		}
		
		/// <summary>
		/// Default unit group for the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultuomscheduleid")]
		public Microsoft.Xrm.Sdk.EntityReference DefaultUoMScheduleId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultuomscheduleid");
			}
			set
			{
				this.SetAttributeValue("defaultuomscheduleid", value);
			}
		}
		
		/// <summary>
		/// Description of the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.SetAttributeValue("description", value);
			}
		}
		
		/// <summary>
		/// Internal Use Only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dmtimportstate")]
		public System.Nullable<int> DMTImportState
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("dmtimportstate");
			}
			set
			{
				this.SetAttributeValue("dmtimportstate", value);
			}
		}
		
		/// <summary>
		/// Shows the default image for the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			set
			{
				this.SetAttributeValue("entityimage", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the product with respect to the base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Hierarchy path of the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hierarchypath")]
		public string HierarchyPath
		{
			get
			{
				return this.GetAttributeValue<string>("hierarchypath");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.SetAttributeValue("importsequencenumber", value);
			}
		}
		
		/// <summary>
		/// Information that specifies whether the product is a kit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iskit")]
		public System.Nullable<bool> IsKit
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("iskit");
			}
			set
			{
				this.SetAttributeValue("iskit", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isreparented")]
		public System.Nullable<bool> IsReparented
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isreparented");
			}
			set
			{
				this.SetAttributeValue("isreparented", value);
			}
		}
		
		/// <summary>
		/// Information about whether the product is a stock item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isstockitem")]
		public System.Nullable<bool> IsStockItem
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isstockitem");
			}
			set
			{
				this.SetAttributeValue("isstockitem", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Shows the external party who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Describes whether product is opted out or not
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_gdproptout")]
		public System.Nullable<bool> msdyn_gdproptout
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_gdproptout");
			}
			set
			{
				this.SetAttributeValue("msdyn_gdproptout", value);
			}
		}
		
		/// <summary>
		/// Name of the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.SetAttributeValue("name", value);
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.SetAttributeValue("overriddencreatedon", value);
			}
		}
		
		/// <summary>
		/// Specifies the parent product family hierarchy.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentproductid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentProductId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentproductid");
			}
			set
			{
				this.SetAttributeValue("parentproductid", value);
			}
		}
		
		/// <summary>
		/// List price for the product item. Used in price calculations.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("price")]
		public Microsoft.Xrm.Sdk.Money Price
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("price");
			}
			set
			{
				this.SetAttributeValue("price", value);
			}
		}
		
		/// <summary>
		/// Value of the List Price in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("price_base")]
		public Microsoft.Xrm.Sdk.Money Price_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("price_base");
			}
		}
		
		/// <summary>
		/// Select the default price list for the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
		public Microsoft.Xrm.Sdk.EntityReference PriceLevelId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pricelevelid");
			}
			set
			{
				this.SetAttributeValue("pricelevelid", value);
			}
		}
		
		/// <summary>
		/// Contains the id of the process associated with the entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.SetAttributeValue("processid", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
		public System.Nullable<System.Guid> ProductId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("productid");
			}
			set
			{
				this.SetAttributeValue("productid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ProductId = value;
			}
		}
		
		/// <summary>
		/// User-defined product ID.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productnumber")]
		public string ProductNumber
		{
			get
			{
				return this.GetAttributeValue<string>("productnumber");
			}
			set
			{
				this.SetAttributeValue("productnumber", value);
			}
		}
		
		/// <summary>
		/// Product Structure.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productstructure")]
		public virtual product_productstructure? ProductStructure
		{
			get
			{
				return ((product_productstructure?)(EntityOptionSetEnum.GetEnum(this, "productstructure")));
			}
			set
			{
				this.SetAttributeValue("productstructure", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		/// <summary>
		/// Type of product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("producttypecode")]
		public virtual product_producttypecode? ProductTypeCode
		{
			get
			{
				return ((product_producttypecode?)(EntityOptionSetEnum.GetEnum(this, "producttypecode")));
			}
			set
			{
				this.SetAttributeValue("producttypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		/// <summary>
		/// URL for the Website associated with the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("producturl")]
		public string ProductUrl
		{
			get
			{
				return this.GetAttributeValue<string>("producturl");
			}
			set
			{
				this.SetAttributeValue("producturl", value);
			}
		}
		
		/// <summary>
		/// Number of decimal places that can be used in monetary amounts for the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantitydecimal")]
		public System.Nullable<int> QuantityDecimal
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("quantitydecimal");
			}
			set
			{
				this.SetAttributeValue("quantitydecimal", value);
			}
		}
		
		/// <summary>
		/// Quantity of the product in stock.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantityonhand")]
		public System.Nullable<decimal> QuantityOnHand
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("quantityonhand");
			}
			set
			{
				this.SetAttributeValue("quantityonhand", value);
			}
		}
		
		/// <summary>
		/// Primary key from Fellowship One that will allow the system to link this Product record with the data in the source system
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quis_f1externalrefid")]
		public string quis_F1ExternalRefID
		{
			get
			{
				return this.GetAttributeValue<string>("quis_f1externalrefid");
			}
			set
			{
				this.SetAttributeValue("quis_f1externalrefid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quis_isjit")]
		public System.Nullable<bool> quis_isJIT
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("quis_isjit");
			}
			set
			{
				this.SetAttributeValue("quis_isjit", value);
			}
		}
		
		/// <summary>
		/// Count of Product that is available for Sale or other uses.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quis_quantityavailable")]
		public System.Nullable<int> quis_QuantityAvailable
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("quis_quantityavailable");
			}
			set
			{
				this.SetAttributeValue("quis_quantityavailable", value);
			}
		}
		
		/// <summary>
		/// Product size.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("size")]
		public string Size
		{
			get
			{
				return this.GetAttributeValue<string>("size");
			}
			set
			{
				this.SetAttributeValue("size", value);
			}
		}
		
		/// <summary>
		/// Contains the id of the stage where the entity is located.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.SetAttributeValue("stageid", value);
			}
		}
		
		/// <summary>
		/// Standard cost for the product item. Used in price calculations.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardcost")]
		public Microsoft.Xrm.Sdk.Money StandardCost
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("standardcost");
			}
			set
			{
				this.SetAttributeValue("standardcost", value);
			}
		}
		
		/// <summary>
		/// Value of the Standard Cost in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardcost_base")]
		public Microsoft.Xrm.Sdk.Money StandardCost_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("standardcost_base");
			}
		}
		
		/// <summary>
		/// Status of the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public virtual product_statecode? StateCode
		{
			get
			{
				return ((product_statecode?)(EntityOptionSetEnum.GetEnum(this, "statecode")));
			}
			set
			{
				this.SetAttributeValue("statecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		/// <summary>
		/// Reason for the status of the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual product_statuscode? StatusCode
		{
			get
			{
				return ((product_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			set
			{
				this.SetAttributeValue("statuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		/// <summary>
		/// Stock volume of the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockvolume")]
		public System.Nullable<decimal> StockVolume
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("stockvolume");
			}
			set
			{
				this.SetAttributeValue("stockvolume", value);
			}
		}
		
		/// <summary>
		/// Stock weight of the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockweight")]
		public System.Nullable<decimal> StockWeight
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("stockweight");
			}
			set
			{
				this.SetAttributeValue("stockweight", value);
			}
		}
		
		/// <summary>
		/// Select a category for the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
		public Microsoft.Xrm.Sdk.EntityReference SubjectId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("subjectid");
			}
			set
			{
				this.SetAttributeValue("subjectid", value);
			}
		}
		
		/// <summary>
		/// Name of the product's supplier.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("suppliername")]
		public string SupplierName
		{
			get
			{
				return this.GetAttributeValue<string>("suppliername");
			}
			set
			{
				this.SetAttributeValue("suppliername", value);
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.SetAttributeValue("timezoneruleversionnumber", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the currency associated with the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.SetAttributeValue("transactioncurrencyid", value);
			}
		}
		
		/// <summary>
		/// A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.SetAttributeValue("traversedpath", value);
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.SetAttributeValue("utcconversiontimezonecode", value);
			}
		}
		
		/// <summary>
		/// Date from which this product is valid.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("validfromdate")]
		public System.Nullable<System.DateTime> ValidFromDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("validfromdate");
			}
			set
			{
				this.SetAttributeValue("validfromdate", value);
			}
		}
		
		/// <summary>
		/// Date to which this product is valid.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("validtodate")]
		public System.Nullable<System.DateTime> ValidToDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("validtodate");
			}
			set
			{
				this.SetAttributeValue("validtodate", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of vendor supplying the product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("vendorid")]
		public string VendorID
		{
			get
			{
				return this.GetAttributeValue<string>("vendorid");
			}
			set
			{
				this.SetAttributeValue("vendorid", value);
			}
		}
		
		/// <summary>
		/// Name of the product vendor.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("vendorname")]
		public string VendorName
		{
			get
			{
				return this.GetAttributeValue<string>("vendorname");
			}
			set
			{
				this.SetAttributeValue("vendorname", value);
			}
		}
		
		/// <summary>
		/// Unique part identifier in vendor catalog of this product.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("vendorpartnumber")]
		public string VendorPartNumber
		{
			get
			{
				return this.GetAttributeValue<string>("vendorpartnumber");
			}
			set
			{
				this.SetAttributeValue("vendorpartnumber", value);
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N product_parent_product
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Product> Referencedproduct_parent_product
		{
			get
			{
				return this.GetRelatedEntities<Product>("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.SetRelatedEntities<Product>("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
			}
		}
		
		/// <summary>
		/// 1:N quis_productimage_Product_product
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quis_productimage_Product_product")]
		public System.Collections.Generic.IEnumerable<quis_ProductImage> quis_productimage_Product_product
		{
			get
			{
				return this.GetRelatedEntities<quis_ProductImage>("quis_productimage_Product_product", null);
			}
			set
			{
				this.SetRelatedEntities<quis_ProductImage>("quis_productimage_Product_product", null, value);
			}
		}
		
		/// <summary>
		/// N:N adx_accountproduct
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_accountproduct")]
		public System.Collections.Generic.IEnumerable<Account> adx_accountproduct
		{
			get
			{
				return this.GetRelatedEntities<Account>("adx_accountproduct", null);
			}
			set
			{
				this.SetRelatedEntities<Account>("adx_accountproduct", null, value);
			}
		}
		
		/// <summary>
		/// N:N adx_contactproduct
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_contactproduct")]
		public System.Collections.Generic.IEnumerable<Contact> adx_contactproduct
		{
			get
			{
				return this.GetRelatedEntities<Contact>("adx_contactproduct", null);
			}
			set
			{
				this.SetRelatedEntities<Contact>("adx_contactproduct", null, value);
			}
		}
		
		/// <summary>
		/// N:1 product_parent_product
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentproductid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Product Referencingproduct_parent_product
		{
			get
			{
				return this.GetRelatedEntity<Product>("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.SetRelatedEntity<Product>("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
			}
		}
	}
}
#pragma warning restore CS1591
