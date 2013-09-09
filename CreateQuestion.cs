using System;
using System.Collections.Generic;

namespace TextAdventure {

	public class CreateQuestion {

		public static string question;
		public static List<string> answers = new List<string>();

		public CreateQuestion (string str, string[] strArray) {

			question = str;

			for (int i = 0; i < strArray.Length; i++) {
				answers.Add (strArray [i]);
			}

		}

		public void addAnswer(string str) {

			answers.Add(str);

		}

		public void printQuestion () {

			Console.WriteLine (question);

			for (int i = 0; i < answers.Count; i++) {

				Console.Write ((i + 1) + ")");
				Console.Write (answers [i]);
				Console.WriteLine ();

			}

		}
	}
}
