using System;

namespace TextAdventure
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Just Comment the Logo out if you don't want it running. It's just for show right now.
			Logo ();
		}

		public static void Logo() {

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine ("   ___,     ______              ___,                                             ");
			Console.WriteLine ("  /   |    (_) |               /   |     |                                       ");
			Console.WriteLine (" |    |        | _      _|_   |    |   __|        _   _  _  _|_         ,_    _  ");
			Console.WriteLine (" |    |      _ ||/  /\\/  |    |    |  /  |  |  |_|/  / |/ |  |  |   |  /  |  |/  ");
			Console.WriteLine ("  \\__/\\_/   (_/ |__/ /\\_/|_/   \\__/\\_/\\_/|_/ \\/  |__/  |  |_/|_/ \\_/|_/   |_/|__/");
			Console.ForegroundColor = ConsoleColor.Gray;

			System.Threading.Thread.Sleep (500);

			Console.Clear();

		}
	}
}
