using UnityEngine;
using System.Collections;

public class HomeMenuPanel : MonoBehaviour {
	GameObject music;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void showMenuPanel(){
		StartCoroutine ("waitforload");

	}

	IEnumerator waitforload(){
		
		yield return new WaitForSeconds(0f);
		GameObject Tobedestroyed = GameObject.Find ("gameOverCanvas");
		Destroy (Tobedestroyed);
		GameObject.Find ("UI").GetComponent<ShowPanels> ().ShowMenu();
		Application.LoadLevel ("Menu");
	}
}
