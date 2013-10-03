using System;
using System.IO;
using System.Collections.Generic;

namespace Utility {

	public static class FileHelper {

		public static List<string> loadPlace(string fileName) {

			string path = "assets/main/places/" + fileName + "/" + fileName + ".txt";
			string buffer;
			List<string> file = new List<string>();

			using (StreamReader reader = new StreamReader(path)) {

				while (!reader.EndOfStream) {

					buffer = reader.ReadLine();

					if (!(buffer.Length == 0) && !buffer.StartsWith("/")) {

						file.Add(buffer);

					}

				}

			}

			return file;

		}

		public static List<string> loadRoom(string directory,string fileName) {

			string place = directory.Replace(" ", string.Empty);
			string room = fileName.Replace(" ", string.Empty);
			string path = "assets/main/places/" + place + "/rooms/" + room+".txt"; 
			string buffer;

			List<string> file = new List<string>();

			using (StreamReader reader = new StreamReader(path)) {

				while (!reader.EndOfStream) {

					buffer = reader.ReadLine();

					if (!(buffer.Length == 0) && !buffer.StartsWith("/")) {

						file.Add(buffer);

					}

				}

			}

			return file;

		}

		public static List<string> loadGraphic(int type, string fileName) {

			string path = "";
			string buffer;

			switch (type) {
				case 0:
					path = "assets/main/places/" + fileName + "/graphics/" + fileName + "Building" + ".txt";
					break;
				case 1:
					path = "assets/main/graphics/other/" + fileName + ".txt";
					break;
			}


			List<string> file = new List<string>();

			using (StreamReader reader = new StreamReader(path)) {

				while (!reader.EndOfStream) {

					buffer = reader.ReadLine();
		
					file.Add(buffer);

				}

			}

			return file;

		}

		public static List<string> loadDescription(int type, string dirName, string fileName) {

			string path = "";
			string buffer;

			switch (type) {
				case 0:
                path = "assets/main/places/" + dirName + "/descriptions/" + fileName + "Description" + ".txt";
					break;
				case 1:
					path = "assets/main/places/" + fileName + fileName + "descriptions" + ".txt";
					break;

			}

			List<string> file = new List<string>();

			using (StreamReader reader = new StreamReader(path)) {

				while (!reader.EndOfStream) {

					buffer = reader.ReadLine();

					file.Add(buffer);


				}

			}

			return file;

		}

		public static Dictionary<string,Coord> loadDirectory() {

			string path = "assets/main/directory.txt";
			string buffer;
			 
			Dictionary<string,Coord> directory = new Dictionary<string, Coord>();

			using (StreamReader reader = new StreamReader(path)) {

				while (!reader.EndOfStream) {

					buffer = reader.ReadLine();

					directory.Add(buffer.Substring(0, 40).Trim(), new Coord(int.Parse(buffer.Substring(41, 3)), int.Parse(buffer.Substring(45, 3))));

				}

			}

			return directory;

		}
	}
}

