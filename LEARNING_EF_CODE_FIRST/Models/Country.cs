// Suppose that your entity's name is Country:
// Id, ID, CountryId, CountryID

namespace Models
{
	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int ID { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int CountryId { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int CountryID { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	/// <summary>
	/// Note: Error On Database Creation!
	/// </summary>
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int AlakiId { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	/// <summary>
	/// Note: Error On Database Creation!
	/// </summary>
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Code { get; set; }

	//	public string Description { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//[System.ComponentModel.DataAnnotations.Schema.Table(name: "CountriesTable")]
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	[System.ComponentModel.DataAnnotations.Schema.Column(name: "CountryId")]
	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Column(name: "CountryName")]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//[System.ComponentModel.DataAnnotations.Schema.Table(name: "TABLE001")]
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	[System.ComponentModel.DataAnnotations.Schema.Column(name: "FIELD001")]
	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Column(name: "FIELD002")]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	// Note: Schema does not work in SQL Server Compact Edition!
	// **************************************************
	//[System.ComponentModel.DataAnnotations.Schema.Table(name: "Countries", Schema = "Cms")]
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	// Note: Does Not Work!
	//[System.ComponentModel.DataAnnotations.Schema.Table(Schema = "Cms")]
	//[System.ComponentModel.DataAnnotations.Schema.Table(name: "", Schema = "Cms")]
	//[System.ComponentModel.DataAnnotations.Schema.Table(name: null, Schema = "Cms")]
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	public int? Area { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required]
	//	public string Name { get; set; }

	//	public string Description { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.MaxLength
	//		(length: 50)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.MinLength
	//		(length: 2)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 3)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	[System.ComponentModel.DataAnnotations.Key]
	//	public int Code { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 3)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	public class Country : object
	{
		public Country() : base()
		{
		}

		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public int Id { get; set; }

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50, MinimumLength = 3)]
		public string Name { get; set; }
	}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//		// Note: Wrong Usage!
	//		//Id = new System.Guid();

	//		Id = System.Guid.NewGuid();
	//	}

	//	public System.Guid Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
	//	public int Code { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 3)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
	//	public int Code { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 1)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	// Note: Wrong Usage!
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
	//	public int Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
	//	public int Code { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 1)]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//		Id = System.Guid.NewGuid();
	//	}

	//	public System.Guid Id { get; set; }

	//	public int Code { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 1)]
	//	public string Name { get; set; }

	//	/// <summary>
	//	/// در جدول بانک اطلاعاتی، تبديل به فيلد نمی گردد
	//	/// </summary>
	//	public string DisplayName
	//	{
	//		get
	//		{
	//			string result =
	//				$"{ Code.ToString().PadLeft(3, '0') } - { Name }";

	//			return result;
	//		}
	//	}
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//		Id = System.Guid.NewGuid();
	//	}

	//	public Country(string someProperty1, string someProperty2) : this()
	//	{
	//		SomeProperty1 = someProperty1;
	//		SomeProperty2 = someProperty2;
	//	}

	//	public System.Guid Id { get; set; }

	//	public int Code { get; set; }

	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 3)]
	//	public string Name { get; set; }

	//	/// <summary>
	//	/// در جدول بانک اطلاعاتی، تبديل به فيلد می‌گردد
	//	/// </summary>
	//	public string SomeProperty1 { get; private set; }

	//	/// <summary>
	//	/// در جدول بانک اطلاعاتی، تبديل به فيلد می‌گردد
	//	/// </summary>
	//	public string SomeProperty2 { get; protected set; }

	//	/// <summary>
	//	/// در جدول بانک اطلاعاتی، تبديل به فيلد نمی‌گردد
	//	/// </summary>
	//	public string DisplayName
	//	{
	//		get
	//		{
	//			string result =
	//				$"{ Code.ToString().PadLeft(3, '0') } - { Name }";

	//			return result;
	//		}
	//	}

	//	/// <summary>
	//	/// در جدول بانک اطلاعاتی، تبديل به فيلد نمی‌گردد
	//	/// </summary>
	//	[System.ComponentModel.DataAnnotations.Schema.NotMapped]
	//	public string SomeProperty3 { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//		Id = System.Guid.NewGuid();
	//	}

	//	public System.Guid Id { get; set; }

	//	/// <summary>
	//	/// Note:
	//	/// 1. Order is Zero based!
	//	/// 2. For changing field type or field order,
	//	/// We should write the property name! (TypeName =)( Order =)
	//	/// </summary>
	//	[System.ComponentModel.DataAnnotations.Required
	//		(AllowEmptyStrings = false)]

	//	[System.ComponentModel.DataAnnotations.StringLength
	//		(maximumLength: 50, MinimumLength = 3)]

	//	// Note: Using TypeName is not recommended!
	//	[System.ComponentModel.DataAnnotations.Schema.Column
	//		(name: "CountryName", Order = 0, TypeName = "Char")]
	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	/// <summary>
	/// با تشکر از آقايان، مهدی مشايخی و حسين شريفی پناه
	/// </summary>
	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//	}

	//	[System.ComponentModel.DataAnnotations.Key]

	//	[System.ComponentModel.DataAnnotations.Schema.Column
	//		(Order = 0)]

	//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
	//	public int Id1 { get; set; }

	//	[System.ComponentModel.DataAnnotations.Key]

	//	[System.ComponentModel.DataAnnotations.Schema.Column
	//		(Order = 1)]

	//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
	//	public int Id2 { get; set; }

	//	public string Name { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	// Note: EF 6+
	// **************************************************
	//public class User : object
	//{
	//	public User() : base()
	//	{
	//		Id = System.Guid.NewGuid();
	//	}

	//	public System.Guid Id { get; set; }

	// توجه مهم: خطا می‌دهد
	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(IsUnique = false)]
	//	public string FullName { get; set; }

	//	[System.ComponentModel.DataAnnotations.MaxLength
	//		(length: 50)]

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(IsUnique = false)]
	//	public string FullName { get; set; }

	//	[System.ComponentModel.DataAnnotations.MaxLength
	//		(length: 20)]

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(IsUnique = true)]
	//	public string Username { get; set; }
	//}
	// **************************************************

	// **************************************************
	//public class Country : object
	//{
	//	public Country() : base()
	//	{
	//		Id = System.Guid.NewGuid();
	//	}

	//	public System.Guid Id { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(IsUnique = true)]
	//	public int Code { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(IsUnique = false)]
	//	public string Name { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(name: "Code1Code2", IsUnique = true, Order = 0)]
	//	public int Code1 { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(name: "Code1Code2", IsUnique = true, Order = 1)]
	//	public int Code2 { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(name: "Code3Code4", IsUnique = false, Order = 1)]
	//	public int Code3 { get; set; }

	//	[System.ComponentModel.DataAnnotations.Schema.Index
	//		(name: "Code3Code4", IsUnique = false, Order = 0)]
	//	public int Code4 { get; set; }
	//}
	// **************************************************
	// **************************************************
	// **************************************************
}
