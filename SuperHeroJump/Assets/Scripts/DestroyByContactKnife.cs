using UnityEngine;
using System.Collections;

public class DestroyByContactKnife : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Knife") {
			Destroy (other.gameObject);
		}
	}
}
