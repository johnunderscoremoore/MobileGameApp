using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScore : MonoBehaviour {

	public Text updatedscore;
	public Text updatedhighscore;
	int gameoverscore;
	int gameoverhighscore;
	// Use this for initialization
	void Start () {
		int gameoverscore = Score.score;
		updatedscore.text = "Score:\n" + gameoverscore;

		if (gameoverscore > PlayerPrefs.GetInt ("JumpScore")) {
			PlayerPrefs.SetInt ("JumpScore", gameoverscore);
		}
		updatedhighscore.text = "BestScore:\n" + PlayerPrefs.GetInt ("JumpScore");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
