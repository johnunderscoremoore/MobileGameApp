using UnityEngine;
using System.Collections;

public class Spikes : MonoBehaviour {
	
	public float move = 0;
	public GameObject spikes;
	public GameObject TextCanvas;
	
	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			StartCoroutine("Ppp");
		}
	}
	
	IEnumerator Ppp(){
		yield return new WaitForSeconds(0.1f);
		Destroy (TextCanvas);
		spikes.transform.position = Vector3.up * move *Time.deltaTime;
		Destroy(gameObject);
	}
}
