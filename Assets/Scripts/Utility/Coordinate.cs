
namespace Dumbo
{	
	public class Coordinate
	{
		public int x;
		public int y;

		public Coordinate(int _x, int _y)
		{
			this.x = _x;
			this.y = _y;
		}


		public static Coordinate operator +(Coordinate c1 , Coordinate c2)
		{
			return new Coordinate (c1.x + c2.x , c1.y + c2.y);
		}

		public static Coordinate operator -(Coordinate c1 , Coordinate c2)
		{
			return new Coordinate (c1.x - c2.x , c1.y - c2.y);
		}

		public static bool operator ==(Coordinate c1 , Coordinate c2)
		{
			if (System.Object.ReferenceEquals (c1, c2))
				return true;
			if ((object)c1 == null || (object)c2 == null)
				return false;
			return c1.x == c2.x && c1.y == c2.y;
		}

		public static bool operator !=(Coordinate c1 , Coordinate c2)
		{
			return !(c1 == c2);
		}

		public override bool Equals (object obj)
		{
			if (!(obj is Coordinate))
				return false;
			Coordinate other = (Coordinate)obj;
			return this.x == other.x && this.y == other.y;
		}

		public override int GetHashCode ()
		{
			return x ^ y;
		}

		public override string ToString ()
		{
			return string.Format ("Coordinate[{0},{1}]", x, y);
		}
	}
}
