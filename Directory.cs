using System;
using System.Collections.Generic;
using Utility;

namespace Reference {
		
	public sealed class Directory {

		static readonly Directory _instance = new Directory();

		public Dictionary<string,Coord> Catalog;

		public static Directory Instance
		{
			get
			{
				return _instance;
			}

		}

		Directory() {

			Catalog = Utility.FileHelper.loadDirectory ();

		}


	}
}

