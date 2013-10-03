using System;
using Utility;
using System.Collections.Generic;

namespace TextAdventure {
	public class Place {
		public string alias;
		public Coord coords;
		public List<string> file;
		public Question actions;
		public Question lookAround;
        public Question talk;
		public Question range;
		private List<Room> _rooms;
        private List<Person> _people;

		public Place(string str1) {

			alias = str1;
            file = Utility.FileHelper.loadPlace(alias.Replace(" ", string.Empty));

			coords = Reference.Directory.Instance.Catalog[alias];
			actions = new Question(file[0], new string[] { file[1], file[2], file[3], file[4], file[5], file[6], file[7], file[8], file[9] });
			lookAround = new Question(file[10], new string[] { file[11], file[12], file[13], file[14], file[15], file[16], file[17], file[18], file[19] });
            talk = new Question(file[20], new string[] { file[21], file[22],file[23], file[24], file[25], file[26], file[27], file[29], file[29]});
			range = travelRange();

		}

		public List<Room> Rooms {

			get {

				if (_rooms == null) {

					_rooms = loadRooms();

				}

				return _rooms;

			}

		}

		private List<Room> loadRooms() {

			List<Room> rooms = new List<Room>();

			for(int i = 0; i < lookAround.answers.Count; i++) {

				rooms.Add(new Room(alias,lookAround.answers[i]));

			}


			return rooms;

		}

		private Question travelRange() {

			Coord start, destination;
			int distance;

			Question travel = new Question("Where do you go?:", new string[] { });

			foreach (KeyValuePair<string, Coord> pair in Reference.Directory.Instance.Catalog) {

				start = Reference.Directory.Instance.Catalog[this.alias];

				destination = new Coord(pair.Value.coordX, pair.Value.coordY);

				distance = Utility.MathHelper.distance(start, destination);

				if (distance <= 10 && distance != 0) {

					travel.addAnswer(pair.Key);

				}

			}

			travel.addAnswer("Exit");

			return travel;

		}
	}
}

