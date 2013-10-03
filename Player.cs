using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Utility;

namespace TextAdventure {

	public class Player {

		public string name;
        public string state;
		public int transportation;
		public Place currentLocation;
		public Room currentRoom;
		public List<string> backpack = new List<string>();

		public Player (string str1, int int1, Place place) {

			name = str1;
			transportation = int1;
			currentLocation = place;

		}

		public void Status() {

			Console.WriteLine ("Location: "+currentLocation.alias);

		}

		public void Interact() {

			int choice,exception = 0;
			string action="";
			Boolean isAction = false;
            state = "place";
			System.Reflection.MemberInfo[] methods;

			Question interact = currentLocation.actions;

			while (!isAction) {

				choice = interact.answerQuestion (exception);

				action = interact.answers [choice-1].Replace(" ",string.Empty);

				methods = this.GetType().GetMethods();

				if (this.GetType().GetMethod (action) != null) {
					isAction = true;
				}
				else {
					exception = 1;
				}

			}

			this.GetType ().InvokeMember (action, BindingFlags.Default | BindingFlags.InvokeMethod, null, this, null);

		}

		public void LookAround() {

			int choice;
            state = "room";
			Question lookAround = currentLocation.lookAround;
			choice = lookAround.answerQuestion ();

			Search (choice-1);

		}

		public void Search(int room) {

			currentRoom = currentLocation.Rooms[room];

			currentRoom.Search();

            this.Interact();

		}

    public void Talk() {
      Question talk = currentLocation.talk;
      int choice;
      choice = talk.answerQuestion ();


    }

		public void Travel () {

			int choice;

			Question travel = currentLocation.range;

			choice = travel.answerQuestion();

			if (choice != 4) {
				currentLocation = new Place (travel.answers [choice - 1].Trim ());
				Utility.TransitionHelper.travelTransition (0, travel.answers [choice - 1].Trim ());
			}

			this.Interact ();

		}
	}
}




