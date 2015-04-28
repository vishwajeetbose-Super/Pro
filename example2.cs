using System;

	public class example1
	{
		private static example1 obj = null;
		
		//public static example1()
		//{
		//	obj = new example1();
		//}

		private example1()
		{
		}
		
		public static example1 GetRepro
		{
			get
			{
				if(obj==null)
				{
					obj = new example1();
				}
				return obj;
			}
		}
		
		public void Print()
		{
			Console.WriteLine("Check");
		}	
		
	}

	public class example2
	{
		public static void Main()
		{	
			var obj = example1.GetRepro;
			obj.Print();
		}
	}
