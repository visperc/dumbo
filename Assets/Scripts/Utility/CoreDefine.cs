using UnityEngine;

namespace Dumbo
{
    public class Screen
    {
        public int width;
        public int height;
        public float aspect 
        {
            get
            {
                return height / width;
            }
        }
        public int size;

        public Screen(int w , int h , int s)
        {
            width = w;
            height = h;
            size = s;
        }
    }
    public static class CoreDefine
    {
        public static readonly int PANHEIGHT = 9;
        public static readonly int PANWIDTH = 9;
		public static readonly float BLOCKHEIGHT = 71.0f;
		public static readonly float BLOCKWIDTH = 71.0f;

        public static readonly int BASESCREENSIZE_WIDTH = 640;
        public static readonly int BASESCREENSIZE_HEIGHT = 1136;
        public static readonly int BASESCREENSIZE_SIZE = 50;
		public static readonly Vector2 ORIGINPOINT = new Vector2(-320 , -568); 

        public static readonly Screen Screen = new Screen(BASESCREENSIZE_WIDTH , BASESCREENSIZE_HEIGHT , BASESCREENSIZE_SIZE);
        

    }
}