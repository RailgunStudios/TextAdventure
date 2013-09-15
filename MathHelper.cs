using System;

namespace Utility {

	public static class MathHelper {

		public static int distance(Coord coord1,Coord coord2) {

			return (int)(Math.Pow((Math.Pow((coord2.coordX-coord1.coordX),2)+Math.Pow((coord2.coordY-coord1.coordY),2)),0.5));

		}

	}
}
