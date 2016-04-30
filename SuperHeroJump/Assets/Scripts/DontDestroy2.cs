using UnityEngine;
using System.Collections;

public class DontDestroy2 : MonoBehaviour {
	
	void Start()
	{
		//Causes UI object not to be destroyed when loading a new scene. If you want it to be destroyed, destroy it manually via script.
		DontDestroyOnLoad(this.gameObject);
	}
	
	
	
}
