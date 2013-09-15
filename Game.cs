using System;
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
			Utility.GraphicsHelper.ReDraw ();

		}

	}
}

