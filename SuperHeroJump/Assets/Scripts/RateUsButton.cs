using UnityEngine;
using System.Collections;

public class RateUsButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PopUp(){
		Application.OpenURL("https://play.google.com/store");
	}

	public void NoAds(){
		Application.OpenURL("https://play.google.com/store");
	}

	public void Like(){
		Application.OpenURL("https://www.facebook.com/pages/Gamify-Studios/293100664198272?sk=timeline");
	}
}
