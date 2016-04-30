using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	public GameObject settingsCanvas;
	public GameObject settingsMenuCanvas;

	public void ChangeToScene (string sceneToChangeTo) {
		Application.LoadLevel(sceneToChangeTo);
	}
	public void home(){
		//GameObject gameMusic =
		//Destroy (gameMusic);
		
		Application.LoadLevel("Menu");
	}

	public void play(){
		Application.LoadLevel ("Main");
		settingsCanvas.SetActive (false);
	}

	public void showSettings(){
		settingsMenuCanvas.SetActive (true);
	}
	public void hideSettings(){
		settingsMenuCanvas.SetActive (false);
	}
}