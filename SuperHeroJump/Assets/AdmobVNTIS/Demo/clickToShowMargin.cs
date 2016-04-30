using UnityEngine;
using System.Collections;

public class clickToShowMargin : MonoBehaviour
{
		void OnMouseDown ()
		{
				AdmobVNTIS x = AdmobVNTIS._get ();
				if (x != null) {
						x.setMargins (0.3f, 0.3f);
						Toast.showText ("You've just clicked margin", Toast.LENGTH_SHORT);
				}
		}
}
