using System;
using System.Collections.Generic;
using TextAdventure;

namespace Utility {

	public class GraphicsHelper {

		public static void ReDraw(int exception = 0) {

			Console.Clear();
			Console.SetWindowSize(100, 33);
			Console.BufferWidth = 100;
			Console.BufferHeight = 33;

			Console.SetCursorPosition (0, 0);
			Utility.GraphicsHelper.quad(25, 98);
			Console.SetCursorPosition (0, 0);
			Utility.GraphicsHelper.quad (25, 30);
			Console.SetCursorPosition (0, 14);
			Utility.GraphicsHelper.quad (11, 30);

			Console.SetCursorPosition (2, 15);
			TextAdventure.Game.player.Status ();

			graphicFromFile (0,Game.player.currentLocation.alias);
			descriptionFromFile (0, Game.player.currentLocation.alias);

			if (exception != 0) {

				switch (exception) {
				case 1: 
					Console.SetCursorPosition (10, 10);
					Utility.GraphicsHelper.quad (10, 30);
					break;
				}

			}

		}

		public static void graphicFromFile(int type, string fileName) {

			string directory;
			string path;
			List<string> file;

			switch (type) {

			case 0:
				directory = "buildings/";
				break;
			case 1: 
				directory = "other/";
				break;
			default:
				directory = "";
				break;

			}

			path = directory + fileName;
			file = FileHelper.loadGraphic (path);

			for (int i = 0; i < file.Count; i++) {
			Console.SetCursorPosition (30, 1+i);
			Console.WriteLine (file [i]);

			}

		}

		public static void descriptionFromFile(int type, string fileName) {

			string directory;
			string path;
			List<string> file;

			switch (type) {

			case 0:
				directory = "defaults/";
				break;
			case 1: 
				directory = "lookaround/";
				break;
			default:
				directory = "";
				break;

			}

			path = directory + fileName;
			file = FileHelper.loadDescription (path);

			for (int i = 0; i < file.Count; i++) {
			Console.SetCursorPosition (2, 25+i);
			Console.WriteLine (file [i]);

			}

		}

		public static void setColor(ConsoleColor color1, ConsoleColor color2 = ConsoleColor.Black) {

			Console.ForegroundColor = color1;

			Console.BackgroundColor = color2;

		}
		
		public static void quad(int height, int width) {

			char[] singleSet = new char[] { (char)218, (char)196, (char)191, (char)179, (char)217, (char)192 };
			char[] doubleSet = new char[] { (char)201, (char)205, (char)187, (char)186, (char)188, (char)200 };

			Console.Write (doubleSet [0]);

			for (int i = 0; i < width - 2; i++) {

				Console.Write (doubleSet [1]);

			}

			Console.WriteLine (doubleSet [2]);

			for (int i = 0; i < height - 2; i++) {

				Console.Write (doubleSet [3]);

				for (int j = 0; j < width - 2; j++) {

					Console.Write (" ");

				}

				Console.WriteLine (doubleSet [3]);


			}

			Console.Write (doubleSet [5]);

			for (int i = 0; i < width - 2; i++) {

				Console.Write (doubleSet [1]);

			}

			Console.WriteLine (doubleSet [4]);


		}


	}
}

