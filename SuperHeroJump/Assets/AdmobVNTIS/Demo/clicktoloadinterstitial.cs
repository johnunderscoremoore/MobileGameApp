using UnityEngine;
using System.Collections;

public class clicktoloadinterstitial : MonoBehaviour
{
		void Start ()
		{
				AdmobVNTIS_Interstitial x = AdmobVNTIS_Interstitial._get ();
				if (x != null) {
						x.OnAdOpened += callThisMethodWhenAdOpened;
				}

		}

		void OnMouseDown ()
		{
				AdmobVNTIS_Interstitial._showInterstitialImmediately ();
		}

		void callThisMethodWhenAdOpened ()
		{
				Toast.showText ("this text show when AdOpened", Toast.LENGTH_LONG);
		}
}
