using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	
	public float jumpSpeed = 5f;

	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Jump")) {
			jump();
		}
	}
	
	public void jump()
	{
		transform.position += Vector3.up * jumpSpeed * Time.deltaTime;
	}
}
