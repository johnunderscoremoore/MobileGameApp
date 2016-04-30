using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public float rotation = 0.0f;
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, rotation) * Time.deltaTime);
	}
}
