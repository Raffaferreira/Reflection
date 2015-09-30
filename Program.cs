using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{

			string rafael = "rafael da silva ferreira";
			float valor = 68.0f;
			int inteiro = 10;


			System.Type tipo = null;
			tipo = inteiro.GetType();
			Console.WriteLine(tipo.Name);
			Console.WriteLine(rafael.GetType().Name);
			Console.Write(valor.GetType().Name);

			var assembly = typeof(Humano).Assembly;
			Type humanType = typeof(Humano);
			var animais = Type.GetType("Terra.Animais");

			object newHuman = Activator.CreateInstance(humanType);

			PropertyInfo[] properties = humanType.GetProperties();
			foreach (var propertyInfo in properties)
			{
				Console.WriteLine(propertyInfo.Name);
			}



			Console.Read();

		}
	}
}
