using System;

//to use repl --> java -jar javarepl.jar
//mcs -out:Defence.exe *.cs && mono Defence.exe
namespace cSharpe
{
	class Game
	{
		static void Main()
		{
			Map map = new Map(8, 5);

			Point point = new Point(4, 2);

			Console.WriteLine(point.DistanceTo(5, 5));
		}
	}

}
