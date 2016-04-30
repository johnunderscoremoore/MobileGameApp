using UnityEngine;
using System.Collections;

public class clickToShowBanner : MonoBehaviour
{
		void OnMouseDown ()
		{
				AdmobVNTIS._showBanner ();
				Toast.showText ("You've just clicked showBanner", Toast.LENGTH_SHORT);
		}
}
