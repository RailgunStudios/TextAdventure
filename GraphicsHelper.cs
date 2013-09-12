using System;

namespace TextAdventure {

	public class GraphicsHelper {

		public static void test() {


			for (char i = (char)176; i <= (char)223; i++) {

				Console.WriteLine ();
				Console.WriteLine ((int)i+": "+i);

			}


		}

		public static void quad(int height, int width) {

			char[] singleSet = new char[] { (char)218, (char)196, (char)191, (char)179, (char)217, (char)192 };
			char[] doubleSet = new char[] { (char)201, (char)205, (char)187, (char)186, (char)188, (char)200 };

			Console.Write (singleSet [0]);

			for (int i = 0; i < width - 2; i++) {

				Console.Write (singleSet [1]);

			}

			Console.WriteLine (singleSet [2]);

			for (int i = 0; i < height - 2; i++) {

				Console.Write (singleSet [3]);

				for (int j = 0; j < width - 2; j++) {

					Console.Write (" ");

				}

				Console.WriteLine (singleSet [3]);


			}

			Console.Write (singleSet [5]);

			for (int i = 0; i < width - 2; i++) {

				Console.Write (singleSet [1]);

			}

			Console.WriteLine (singleSet [4]);





		}


	}
}

