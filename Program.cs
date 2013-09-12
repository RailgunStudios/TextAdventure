using System;
using Reference;

namespace TextAdventure {

	class MainClass {

		public static void Main (string[] args) {
		
			init ();
			ConsoleKeyInfo info;

			Place current = Reference.places.home;

			Question travel = new Question ("Where do you go?", new string[] {
				"Police Department",
				"Bar",
				"Food Market",
				"Park"
			});

			Console.WriteLine (util.math.distance (0, 0, 1, 1));

			System.Threading.Thread.Sleep (10000);


		}

		public static void init() {

			Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252);

			Console.Clear();
			Console.SetWindowSize(100, 33);
			Console.BufferWidth = 100;
			Console.BufferHeight = 33;

			//Logo ();

		}

		public static void Logo () {

			GraphicsHelper.quad (9,84);
			Console.SetCursorPosition (0,2);

			util.console.setColor (Reference.colors.darkYellow);
			util.console.print ("  ___,     ______              ___,                                             ");
			util.console.print (" /   |    (_) |               /   |     |                                       ");
			util.console.print ("|    |        | _      _|_   |    |   __|        _   _  _  _|_         ,_    _  ");
			util.console.print ("|    |      _ ||/  /\\/  |    |    |  /  |  |  |_|/  / |/ |  |  |   |  /  |  |/  ");
			util.console.print (" \\__/\\_/   (_/ |__/ /\\_/|_/   \\__/\\_/\\_/|_/ \\/  |__/  |  |_/|_/ \\_/|_/   |_/|__/");
			util.console.setColor (Reference.colors.gray);

			GraphicsHelper.quad (10,10);
			GraphicsHelper.quad (9,84);


			System.Threading.Thread.Sleep (500);


		}
	}
}
