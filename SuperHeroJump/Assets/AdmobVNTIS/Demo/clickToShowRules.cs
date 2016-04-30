using UnityEngine;
using System.Collections;

public class clickToShowRules : MonoBehaviour
{
		void OnMouseDown ()
		{
				AdmobVNTIS x = AdmobVNTIS._get ();
				if (x != null) {
						AdmobVNTIS.Rules[] rules = new AdmobVNTIS.Rules[2];
						rules [0] = AdmobVNTIS.Rules.ALIGN_PARENT_LEFT;
						rules [1] = AdmobVNTIS.Rules.CENTER_VERTICAL;
						x.setRules (rules, 2);
						Toast.showText ("You've just clicked rules", Toast.LENGTH_SHORT);
				}
		}
}
