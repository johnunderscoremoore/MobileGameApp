using UnityEngine;
using System.Collections;

public class IntroChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine ("ChangeLevel");
	}

	IEnumerator ChangeLevel()
	{
		yield return new WaitForSeconds(2);
		GameObject.Find ("ChangeScene").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds(1.2f);
		Application.LoadLevel ("Menu");


	}
}
