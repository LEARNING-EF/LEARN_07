namespace Models
{
	public class SampleClass : object
	{
		public SampleClass()
		{
			Id = System.Guid.NewGuid();
		}

		public System.Guid Id { get; set; }

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public int Code { get; set; }

		[System.ComponentModel.DataAnnotations.Schema.Index]
		public bool IsActive { get; set; }

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 2)]
		public string Name { get; set; }

		public string Description { get; set; }
	}
}
