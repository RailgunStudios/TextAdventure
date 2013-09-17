using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Utility;

namespace TextAdventure {

	public class Room {

		public List<string> file;
		public string[] layout;
		public string[] defaultLayout;
		public string alias;
		public int startLayout, endLayout;

		public Room(string placeName,string roomName) {

			alias = roomName;
			file = Utility.FileHelper.loadRoom(placeName,roomName);



			startLayout = file.IndexOf("Layout");
			endLayout = file.IndexOf("End Layout");


			layout = readLayout(startLayout, endLayout);
			defaultLayout = layout;



		}

		public void Search() {

			Regex regex = new Regex("^[0-9]*$");
			string input;
			Console.SetCursorPosition (3, 13);
			input = Console.ReadLine();

			if (regex.IsMatch(input)) {
				Console.WriteLine(input);

			}

		}

		private Coord getValidCoord() {

			Boolean isValid = false,xisValid = false,yisValid = false;

			int x=0, y=0;
			string strX, strY;
			Coord search;

			while(!isValid) {

				Utility.GraphicsHelper.ReDraw();
				Utility.GraphicsHelper.drawRoomLayout(layout);

				xisValid = false;
				yisValid = false;

				while (!xisValid) {

					Utility.GraphicsHelper.ReDraw();
					Utility.GraphicsHelper.drawRoomLayout(layout);
					Console.SetCursorPosition (3, 13);
					Console.Write("Coord X: ");
					strX = Console.ReadLine();

					if (int.TryParse(strX, out x)&& x >= 0) {

						xisValid = true;

					}

				}

				while (!yisValid) {

					Utility.GraphicsHelper.ReDraw();
					Utility.GraphicsHelper.drawRoomLayout(layout);
					Console.SetCursorPosition (3, 13);
					Console.Write("Coord Y: ");
					strY = Console.ReadLine();

					if (int.TryParse(strY, out y) && y >= 0) {

						yisValid = true;

					}

				}

				if (y < layout.Length) {

					if (x < layout[y].Length) {

						isValid = true;

					}

				}



			}

			Console.Write(x + " " + y);
			Console.ReadKey();

			search = new Coord(x, y);

			return search;

		}

		private string[] readLayout(int start, int end) {

			string[] layout;
			int fileStart = start+1;

			layout = new string[end-1];

			for (int i = 0; i < end-1; i++) {

				layout[i] = file[i + (fileStart)];

			}

			return layout;


		}
	}
}

