using UnityEngine;
using System.Collections;

public class AdmobVNTIS_Interstitial : MonoBehaviour
{

		public string InterstitialAdUnitID = "YOUR_AD_UNIT_ID";
		public string TestDeviceID = "";
		public bool ShowInterstitialOnLoad = false;
		public bool isAdLoaded = false;
		public int numberOfImpressions = 0;
		private static AndroidJavaObject jo;
		float retryTimeOut = 1.0f;
		[Range(0,100)]
		int	extendTimeOutPercent = 0;
		int timeOutMax = 90;
		float retryTime;
		float current;
		bool isFail = false;
		float totalretryTime = 0.0f;
		// Dont destroy on load and prevent duplicate
		private static bool created = false;

		void Awake ()
		{
				if (!created) {
						DontDestroyOnLoad (this.gameObject);
						created = true;
						initializeInterstitial ();
				} else {
						Destroy (this.gameObject);
				}
				retryTime = retryTimeOut;
				current = 0.0f;
		}

		void initializeInterstitial ()
		{
				jo = new AndroidJavaObject ("admob.admob", InterstitialAdUnitID, TestDeviceID, ShowInterstitialOnLoad);
		}

		/// <summary>
		/// Show the interstitial. Load if ad is not loaded, and show after load.
		/// </summary>
		public void showInterstitial ()
		{
				jo.Call ("showInterstitial");
		}

		/// <summary>
		/// Show the interstitial. Load if ad is not loaded, and NOT show after load.
		/// </summary>
		public void showInterstitialImmediately ()
		{
				jo.Call ("showInterstitialImmediately");
		}

		/// <summary>
		/// Load the interstitial. Ignore if already loaded.
		/// </summary>
		public void prepareInterstitial ()
		{
				jo.Call ("prepareInterstitial");
		}		


		public delegate void listener ();

		public event listener OnAdLoaded;

		public void onAdLoaded (string msg)
		{
				retryTime = retryTimeOut;
				totalretryTime = 0.0f;
				current = 0.0f;
				isAdLoaded = true;
				if (OnAdLoaded != null)
						OnAdLoaded ();
		}

		public event listener OnAdOpened;

		public void onAdOpened (string msg)
		{
				isAdLoaded = false;
				numberOfImpressions++;
				if (OnAdOpened != null)
						OnAdOpened ();
		}

		public event listener OnAdLeftApplication;
		
		public void onAdLeftApplication ()
		{
				if (OnAdLeftApplication != null)
						OnAdLeftApplication ();
		}

		public event listener OnAdClosed;
		
		public void onAdClosed ()
		{
				if (OnAdClosed != null)
						OnAdClosed ();
		}
		
		public event listener OnAdFailedToLoad;

		public void onAdFailedToLoad (string errorCode)
		{
				if (timeOutMax != 0 && timeOutMax < totalretryTime) {
						// do nothing
				} else {
						isFail = true;
						totalretryTime += retryTime;
						if (OnAdFailedToLoad != null)
								OnAdFailedToLoad ();
				}
		}

		void Update ()
		{
				if (isFail) {
						if (current < retryTime) {
								current += Time.deltaTime;
						} else {
								isFail = false;
								current = 0.0f;
								retryTime += (float)(extendTimeOutPercent * retryTime);
								prepareInterstitial ();
						}			    
				}
		}

		public static void _showInterstitial ()
		{
				AdmobVNTIS_Interstitial ai = (AdmobVNTIS_Interstitial)GameObject.Find ("AdmobVNTISInterstitialObject").GetComponent ("AdmobVNTIS_Interstitial");
				if (ai != null) {
						ai.showInterstitial ();
				}
		}

		public static void _showInterstitialImmediately ()
		{
				AdmobVNTIS_Interstitial ai = (AdmobVNTIS_Interstitial)GameObject.Find ("AdmobVNTISInterstitialObject").GetComponent ("AdmobVNTIS_Interstitial");
				if (ai != null) {
						ai.showInterstitialImmediately ();
				}
		}

		public static int _numberOfImpressions ()
		{
				AdmobVNTIS_Interstitial ai = (AdmobVNTIS_Interstitial)GameObject.Find ("AdmobVNTISInterstitialObject").GetComponent ("AdmobVNTIS_Interstitial");
				if (ai != null) {
						return ai.numberOfImpressions;
				}
				return -1;
		}

		public static void _setNumberOfImpressions (int n)
		{
				AdmobVNTIS_Interstitial ai = (AdmobVNTIS_Interstitial)GameObject.Find ("AdmobVNTISInterstitialObject").GetComponent ("AdmobVNTIS_Interstitial");
				if (ai != null) {
						ai.numberOfImpressions = n;
				}
		}

		public static bool _isAdLoaded ()
		{
				AdmobVNTIS_Interstitial ai = (AdmobVNTIS_Interstitial)GameObject.Find ("AdmobVNTISInterstitialObject").GetComponent ("AdmobVNTIS_Interstitial");
				if (ai != null) {
						return ai.isAdLoaded;
				}
				return false;
		}

		public static AdmobVNTIS_Interstitial _get ()
		{
				return (AdmobVNTIS_Interstitial)GameObject.Find ("AdmobVNTISInterstitialObject").GetComponent ("AdmobVNTIS_Interstitial");
		}

}
