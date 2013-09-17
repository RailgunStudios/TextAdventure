using System;
using System.Media;
using Reference;
using Utility;
using System.Collections.Generic;

namespace TextAdventure {

	public class Game {

		public static Player player;
		public static Place currentPlace;

		public static void Start(){

		init ();
				
		player.Interact ();
		
		}

		public static void init() {

			Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252);

			currentPlace = new Place ("Home");

			player = new Player ("John Carter",1,currentPlace);
			player.backpack.Add ("Test");

			Console.Clear();
			Console.SetWindowSize(122, 25);
			Console.BufferWidth = 122;
			Console.BufferHeight = 25;

			Utility.GraphicsHelper.graphicFromFile (1, "intro");
			Console.ReadKey ();

			Utility.GraphicsHelper.ReDraw ();

		}

	}
}

