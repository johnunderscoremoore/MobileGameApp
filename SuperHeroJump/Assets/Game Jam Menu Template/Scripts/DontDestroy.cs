using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	void Awake()
	{
		//Causes UI object not to be destroyed when loading a new scene. If you want it to be destroyed, destroy it manually via script.
		DontDestroyOnLoad(this.gameObject);
		if (FindObjectsOfType(GetType()).Length > 1)
		{
			Destroy(gameObject);
		}

	}

	void Update(){

	}
	

}
