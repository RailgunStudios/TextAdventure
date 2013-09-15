using System;	

namespace Utility {
	public class TransitionHelper {

		public static void travelTransition(int mode, string destination) {
		
			string verb = "Going";

			switch (mode) {

			case 0:
				verb = "Walking";
				break;


			}

			Console.SetCursorPosition (3, 13);
			Console.Write (" ");

			Console.SetCursorPosition (2, 22);
			Console.WriteLine(verb +" to " + destination);

			for (int i = 0; i < 26; i++) {
			Console.SetCursorPosition (2+i, 23);
			Console.Write ((char)178);
			System.Threading.Thread.Sleep(75);

			}
			System.Threading.Thread.Sleep(100);


		}

	}
}

