using System;

namespace TextAdventure {

	public static class util {

		public static class console {

			public static void print (String str, int mode = 1) {
					
				switch (mode) {

				case 0:
					Console.Write (str);
					break;
				case 1:
					Console.WriteLine (str);
					break;

				}	
			
			}

			public static void setColor(ConsoleColor color1, ConsoleColor color2 = ConsoleColor.Black) {

				Console.ForegroundColor = color1;

				if (color2 != ConsoleColor.Black) {

					Console.BackgroundColor = color2;

				}


			}

		}

		public static class math {

			public static int distance(double x1, double y1, double x2, double y2) {

				return (int)(Math.Pow((Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)),0.5));

			}

		}
		
	}
}
