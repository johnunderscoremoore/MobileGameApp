using UnityEngine;
using System.Collections;

public class DestroyByContactGrenade : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			Destroy(other.gameObject);
		}
}
}
