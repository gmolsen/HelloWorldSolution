using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject {
	class Program {
		// properties (variables) go first
		static int Age;
		int Counter = 0;
		// methods (functions) go last

		int IncrementNumber(int nbr) {
			int incrementValue = 7;
			return nbr + incrementValue;
		}

		int AddNumbers(int parameter1, int parameter2) {
			return parameter1 + parameter2;
		}

		int AddNumbers(int parameter1, int parameter2, int parameter3) {
			return parameter1 + parameter2 + parameter3;
		}

		double AddNumbers(double parameter1, double parameter2) {
			return parameter1 + parameter2;
		}

		int SubtractTwoNumbers(int parameter1, int parameter2) {
			return parameter1 - parameter2;
		}

		void Print(string message) {
			Console.WriteLine(message);
		}

		string ToFullName(string name1, string name2) {
			return $"{name1}{name2}";
		}

		static void Main(string[] args) {
			new Program().Run();
		}
		void Run() {
			var FullName2 = ToFullName("Greg"," Olsen");
			Print(FullName2);
			Print(IncrementNumber(6).ToString());
			var sum = AddNumbers(2, 3);
			Print(sum.ToString());
			Print(AddNumbers(2, 3, 4).ToString());
			Print(AddNumbers(2.2, 3.3).ToString());
			var diff = SubtractTwoNumbers(5, 3);
			Print(diff.ToString());
			Print("Hello World!");
			Age = 0;
			Print(Age.ToString());
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