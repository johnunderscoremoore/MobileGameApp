using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		StartCoroutine ("music");
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	IEnumerator music(){
		yield return new WaitForSeconds(4.1f);
		GetComponent<AudioSource>().Play ();
	}
}
