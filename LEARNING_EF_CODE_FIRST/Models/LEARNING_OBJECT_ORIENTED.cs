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

	//	private int _age;

	//	public int Age
	//	{
	//		get
	//		{
	//			return (_age);
	//		}
	//		set
	//		{
	//			_age = value;
	//		}
	//	}
	//}

	//public class Person : object
	//{
	//	public Person()
	//	{
	//	}

	//	private int _age;

	//	public int Age
	//	{
	//		get
	//		{
	//			return (_age);
	//		}
	//		set
	//		{
	//			if ((value >= 1) && (value <= 99))
	//			{
	//				_age = value;
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
	//		//_age = age;

	//		//if ((age >= 1) && (age <= 99))
	//		//{
	//		//	_age = age;
	//		//}

	//		Age = age;
	//	}

	//	private int _age;

	//	public int Age
	//	{
	//		get
	//		{
	//			return (_age);
	//		}
	//		set
	//		{
	//			if ((value >= 1) && (value <= 99))
	//			{
	//				_age = value;
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

	//		_salary = salary;
	//	}

	//	private int _salary;

	//	public int Salary
	//	{
	//		get
	//		{
	//			return (_salary);
	//		}
	//	}
	//}

	public class Person : object
	{
		public Person()
		{
		}

		public Person(int salary)
		{
			Salary = salary;
		}

		private int _salary;

		public int Salary
		{
			get
			{
				return (_salary);
			}
			//private set
			protected set
			{
				_salary = value;
			}
		}
	}
}
