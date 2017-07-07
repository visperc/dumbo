using UnityEngine;

namespace Dumbo
{
	public static class CoreUtility
	{
		public static Vector2 CoordinateToPosition(Coordinate coord)
		{
			Vector2 result = new Vector2 (CoreDefine.ORIGINPOINT.x , CoreDefine.ORIGINPOINT.y);
			result.x = CoreDefine.ORIGINPOINT.x + coord.x * CoreDefine.BLOCKWIDTH + 0.5f * CoreDefine.BLOCKWIDTH;
			result.y = CoreDefine.ORIGINPOINT.y + coord.y * CoreDefine.BLOCKHEIGHT + 0.5f * CoreDefine.BLOCKHEIGHT; 
			return result;
		}

		public static Coordinate PositionToCoordinate(Vector2 pos)
		{
			return new Coordinate ((int)(pos.x / CoreDefine.BLOCKWIDTH) , (int)(pos.y / CoreDefine.BLOCKHEIGHT));
		}

		public static Coordinate PositionToCoordinate(Vector3 pos)
		{
			return PositionToCoordinate (new Vector2(pos.x , pos.y));
		}
	}
}

