using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject {
	class Program {
		// properties (variables) go first
		static int Age;
		// methods (functions) go last
		static void Main(string[] args) {
			Console.WriteLine("Hello World!");
			Age = 0;
			Console.WriteLine(Age);
			int Counter = 1;
			Console.WriteLine("Value of counter is " + Counter);
			int numerator = 5;
			int denominator = 2;
			Console.WriteLine(numerator + " / " + denominator + " = " + numerator / denominator);
			var aLong = 42L; // initializes a long variable type
			double pi = 3.1419;
			double r = 1.0;
			double two = 2.0;
			double answer;
			answer = two * pi * r;
			Console.WriteLine(answer);
			var a = 3;
			var b = 4;
			var c = Math.Sqrt((a * a) + (b * b));
			Console.WriteLine("c equals " + c);

			string s = "This is a string.";
			var sUppercase = s.ToUpper();
			var sLowercase = s.ToLower();
			Console.WriteLine(s);
			Console.WriteLine(sUppercase);
			Console.WriteLine(sLowercase);

			var FirstName = "Greg";
			var LastName = "Olsen";
			var FullName = FirstName + " " + LastName;
			Console.WriteLine("Hello, my name is " + FullName + ".");
			string aNullValue = null;

			string aNewFullName = $"{FirstName} {LastName}";
			Console.WriteLine(aNewFullName);

			string AreaCode = "513";
			string Exchange = "555";
			string Number = "1212";
			string Phone = $"({AreaCode})-{Exchange}-{Number}";
			Console.WriteLine(Phone);
			Console.WriteLine($"{aNewFullName} phone number is ({AreaCode})-{Exchange}-{Number}");
			var message = $"{aNewFullName} phone number is ({AreaCode})-{Exchange}-{Number}";
			Console.WriteLine(message);

			//booleans
			bool TrueValue = true;
			bool HasBlondHair = false;//or false
			Console.WriteLine($"The value of the TrueValue variable is {TrueValue}");
			Console.WriteLine(!TrueValue);
		}
	}
}