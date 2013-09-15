using System;
using System.Collections.Generic;

namespace TextAdventure {

	public class Question {

		public string question;
		public List<string> answers = new List<string>();

		public Question (string str, string[] strArray) {

			question = str;

			for (int i = 0; i < strArray.Length; i++) {

				if (strArray [i] != "N/A") {
					answers.Add (strArray [i]);
				}

			}

		}

		public void addAnswer(string str) {

			answers.Add(str);

		}

		public int answerQuestion(int exception = 0) {

			Boolean isValid = false;
			ConsoleKeyInfo info;
			int choice=0;

			if (exception > 0) {

				switch (exception) {

				case 1:
					Console.SetCursorPosition (3, 13);
					Console.Write (" ");
					Utility.GraphicsHelper.setColor (ConsoleColor.Yellow,ConsoleColor.DarkBlue);
					Console.SetCursorPosition (0, 8);
					Utility.GraphicsHelper.quad (5, 80);	
					Console.SetCursorPosition (10, 10);	
					Console.WriteLine ("This is action is not implemented. Press any key to continue...");
					Console.SetCursorPosition (3, 13);
					Console.ReadKey ();
					Utility.GraphicsHelper.setColor (ConsoleColor.Gray);
					break;

				}


			}

			while(!isValid) {

				Utility.GraphicsHelper.ReDraw ();

				this.printQuestion ();
				Console.SetCursorPosition (3, 13);
				info = Console.ReadKey();
				choice = (int)Char.GetNumericValue (info.KeyChar);

				if((choice-1) < this.answers.Count && choice > 0) {
					isValid = true;
				}


			}

			return choice;

		}

		private void printQuestion () {
			Console.SetCursorPosition (3, 2);
			Console.WriteLine (question);

			for (int i = 0; i < answers.Count; i++) {
				Console.SetCursorPosition (3, 3+i);
					Console.Write ((i + 1) + ")");
					Console.Write (answers [i]);
					Console.WriteLine ();
			}

		}
		
	}
}
