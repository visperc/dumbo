using UnityEngine;
using Dumbo.Core;

namespace Dumbo
{
    public class CorePanRender : MonoBehaviour
    {
        // public GameObject 
        public CorePan mPan;

        void Start()
        {
            Init();
        } 

        void Init()
        {
			InitPan ();
        }

        void InitPan()
        {
			GameObject prefab = Resources.Load ("Pan/PanBlock") as GameObject;

			for(int i = 0 ; i < CoreDefine.PANWIDTH ; i++)
			{
				for(int j = 0 ; j < CoreDefine.PANHEIGHT ; j++)
				{
					GameObject obj = GameObject.Instantiate (prefab) as GameObject;
					obj.transform.SetParent (transform,false);
					Coordinate coord = new Coordinate (i , j);
					obj.transform.localPosition = CoreUtility.CoordinateToPosition (coord);
				}
			}
        }

        void Reset()
        {

        }
    }
}