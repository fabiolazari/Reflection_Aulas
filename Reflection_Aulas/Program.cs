using System;

namespace Reflection_Aulas
{
	class Program
	{
		static void Main(string[] args)
		{
			var objetoA = new A
			{
				Id = 100,
				Descricao = "Valor descrição"
			};

			var objetoB = new B();

			var propriedadeA = objetoA.GetType().GetProperties();

			foreach (var propA in propriedadeA)
			{
				var propertyInfoB = objetoB.GetType().GetProperty(propA.Name);

				if (propertyInfoB != null)
				{
					propertyInfoB.SetValue(objetoB, propA.GetValue(objetoA));
				}
			}


			Console.WriteLine("====== Valor de A ======");
			Console.WriteLine(objetoA.Id);
			Console.WriteLine(objetoA.Descricao);


			Console.WriteLine("====== Valor de A ======");
			Console.WriteLine(objetoB.Id);
			Console.WriteLine(objetoB.Descricao);

			Console.ReadLine();
		}
	}

	class A
	{
		public int Id { get; set; }
		public string Descricao { get; set; }
	}

	class B
	{
		public int Id { get; set; }
		public string Descricao { get; set; }
	}
}
