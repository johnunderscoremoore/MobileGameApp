using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {

	public GameObject controlCanvas;

	// Use this for initialization
	public void ShowCanvas() {
		controlCanvas.SetActive (true);
	}
	
	// Update is called once per frame
	public void HideCanvas() {
		controlCanvas.SetActive (false);
	}
}
