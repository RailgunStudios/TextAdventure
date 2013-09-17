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
			descriptionFromFile (0, Game.player.currentLocation.alias);

				switch (exception) {
				case 0:
				graphicFromFile (0, Game.player.currentLocation.alias);
					break;
				case 1: 
				Console.SetCursorPosition (31, 2);
					break;
				case 2:
					break;

				}
		}
		

		public static void graphicFromFile(int type, string fileName) {

			string path;
			int maxLength=0;
			List<string> file;

			path = fileName;
			file = FileHelper.loadGraphic (type, path);

			for (int i = 0; i < file.Count; i++) {

				if (file [i].Length > maxLength) {
					
					maxLength = file [i].Length;

				}

			}

			for (int i = 0; i < file.Count; i++) {
			Console.SetCursorPosition (30+((66-maxLength)/2), ((25-file.Count)/2)+i);
			Console.WriteLine (file [i]);

			}

		}

		public static void descriptionFromFile(int type, string fileName) {

			string path;
			List<string> file;


			path = fileName;
			file = FileHelper.loadDescription (type,path);

			for (int i = 0; i < file.Count; i++) {
			Console.SetCursorPosition (2, 25+i);
			Console.WriteLine (file [i]);

			}

		}

		public static void drawRoomLayout(string[] layout) {

			int maxLength = 0;
			int maxHeight = layout.Length;

			Console.SetCursorPosition (2, 1);
			Console.WriteLine(Game.player.currentRoom.alias);

			for (int i = 0; i < layout.Length; i++) {

				if (layout [i].Length > maxLength) {

					maxLength = layout [i].Length;

				}

			}

			for (int i = 0; i < layout.Length; i++) {
				Console.SetCursorPosition (((30-maxLength)/2), ((15-maxHeight)/2)+i);
				Console.WriteLine(layout[i]);

			}

		}

		public static void setColor(ConsoleColor color1 = ConsoleColor.Gray, ConsoleColor color2 = ConsoleColor.Black) {

			Console.ForegroundColor = color1;

			Console.BackgroundColor = color2;

		}
		
		public static void quad(int height, int width,ConsoleColor color = ConsoleColor.Gray) {

			char[] singleSet = new char[] { (char)218, (char)196, (char)191, (char)179, (char)217, (char)192 };
			char[] doubleSet = new char[] { (char)201, (char)205, (char)187, (char)186, (char)188, (char)200 };

			setColor (color);

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

			setColor ();
		}


	}
}

