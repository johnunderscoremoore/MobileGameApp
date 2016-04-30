using UnityEngine;
using System.Collections;

public class CameraAdjust : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Camera.main.aspect = 1080f / 1920f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
