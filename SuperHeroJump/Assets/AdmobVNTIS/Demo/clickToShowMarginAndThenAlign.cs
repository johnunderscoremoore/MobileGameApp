using UnityEngine;
using System.Collections;

public class clickToShowMarginAndThenAlign : MonoBehaviour
{
		void OnMouseDown ()
		{
				AdmobVNTIS x = AdmobVNTIS._get ();
				if (x != null) {
						x.setMargins (0.1f, 0.0f);
						AdmobVNTIS.Rules[] rules = new AdmobVNTIS.Rules[1];
						rules [0] = AdmobVNTIS.Rules.ALIGN_PARENT_BOTTOM;
						x.setRules (rules, 1);
						Toast.showText ("You've just clicked margin&align", Toast.LENGTH_SHORT);
				}
		}
}
