namespace Models
{
	//public class Person : object
	//{
	//	public Person()
	//	{
	//	}

	//	// به عنوان يک حرفه‌ای، هيچگاه از فيلد عمومی استفاده نمی‌کنيم
	//	// .تعریف می‌کنیم Property نوشته، و معادل آن یک private بلکه آن را به صورت
	//	public int Age;
	//}

	//public class Person : object
	//{
	//	public Person()
	//	{
	//	}

	//	private int age;

	//	public int Age
	//	{
	//		get
	//		{
	//			return age;
	//		}
	//		set
	//		{
	//			age = value;
	//		}
	//	}
	//}

	//public class Person : object
	//{
	//	public Person()
	//	{
	//	}

	//	private int age;

	//	public int Age
	//	{
	//		get
	//		{
	//			return age;
	//		}
	//		set
	//		{
	//			if ((value >= 1) && (value <= 99))
	//			{
	//				age = value;
	//			}
	//		}
	//	}
	//}

	/// <summary>
	///.متناظر آن استفاده می‌کنیم property دسترسی مستقیم داریم، ولی برای دسترسی (خواندن و نوشتن) به آنها باز هم از private هر چند که در داخل کلاس به فیلدهای
	/// </summary>
	//public class Person : object
	//{
	//	public Person()
	//	{
	//	}

	//	public Person(int age)
	//	{
	//		//age = age;

	//		//if ((age >= 1) && (age <= 99))
	//		//{
	//		//	age = age;
	//		//}

	//		Age = age;
	//	}

	//	private int age;

	//	public int Age
	//	{
	//		get
	//		{
	//			return age;
	//		}
	//		set
	//		{
	//			if ((value >= 1) && (value <= 99))
	//			{
	//				age = value;
	//			}
	//		}
	//	}
	//}

	//public class Person : object
	//{
	//	public Person()
	//	{
	//	}

	//	public Person(int salary)
	//	{
	//		Salary = salary;

	//		this.salary = salary;
	//	}

	//	private int salary;

	//	public int Salary
	//	{
	//		get
	//		{
	//			return salary;
	//		}
	//	}
	//}

	public class Person : object
	{
		public Person(int salary)
		{
			Salary = salary;
		}

		//public int Salary { get; private set; }
		public int Salary { get; protected set; }
	}
}
