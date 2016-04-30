using UnityEngine;
using System.Collections;

public class clickToHideBanner : MonoBehaviour
{
		void OnMouseDown ()
		{
				AdmobVNTIS._hideBanner ();
				Toast.showText ("You've just clicked hideBanner", Toast.LENGTH_SHORT);
		}
}
