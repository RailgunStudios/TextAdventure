using System;

namespace TextAdventure {

	class MainClass {

		public static void Main (string[] args) {
			
			Logo ();
			ConsoleKeyInfo info;
			Question test = new Question ("Which Direction do you travel?", new string[] {
				"North",
				"South",
				"East",
				"West"
			});



			test.printQuestion ();
			info = Console.ReadKey ();

			if (info.KeyChar == 'a') {

				Console.WriteLine ("Why Hello, World");

			}

		}

		public static void Logo () {

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine ("   ___,     ______              ___,                                             ");
			Console.WriteLine ("  /   |    (_) |               /   |     |                                       ");
			Console.WriteLine (" |    |        | _      _|_   |    |   __|        _   _  _  _|_         ,_    _  ");
			Console.WriteLine (" |    |      _ ||/  /\\/  |    |    |  /  |  |  |_|/  / |/ |  |  |   |  /  |  |/  ");
			Console.WriteLine ("  \\__/\\_/   (_/ |__/ /\\_/|_/   \\__/\\_/\\_/|_/ \\/  |__/  |  |_/|_/ \\_/|_/   |_/|__/");
			Console.ForegroundColor = ConsoleColor.Gray;

			System.Threading.Thread.Sleep (500);


		}
	}
}
