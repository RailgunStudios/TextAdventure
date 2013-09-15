using System;
using Utility;
using System.Collections.Generic;

namespace TextAdventure {

	public class Place {
		
		public string alias;
		public Coord coords;
		public List<string> file;
		public Question actions;
		public Question range;

		public Place (string str1) {

			alias = str1;
			file = Utility.FileHelper.loadPlace (alias);

			coords = Reference.Directory.Instance.Catalog [alias];
			actions = new Question (file [0], new string[]{file[1],file[2],file[3],file[4],file[5],file[6],file[7],file[8],file[9],file[10]});
			range = travelRange ();

		}

		private Question travelRange() {

			Coord start, destination;
			int distance;

			Question travel = new Question ("Where do you go?:", new string[]{ });

			foreach (KeyValuePair<string, Coord> pair in Reference.Directory.Instance.Catalog) {

				start = Reference.Directory.Instance.Catalog [this.alias];

				destination = new Coord (pair.Value.coordX, pair.Value.coordY);

				distance = Utility.MathHelper.distance (start, destination);

				if (distance<= 10 && distance != 0) {

					travel.addAnswer (pair.Key);

				}

			}

			travel.addAnswer ("Exit");

			return travel;

		}

	}
}

