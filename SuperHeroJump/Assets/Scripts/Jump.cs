using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float jumpSpeed = 240f;
	private Rigidbody2D body2d;
	private bool ro = false;
	void Start(){
		ro = false;
	}
	void Awake () {
		body2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	
		if (Input.GetButton ("Jump")) {
			jump();

		}

		if (ro) {
			transform.Rotate (new Vector3 (0, 0, 360) * Time.deltaTime);
		}
	}

	public void jump()
	{
		
		GetComponent<AudioSource>().Play();
		body2d.velocity = new Vector2 (0, jumpSpeed);
		ro = true;
	}
}
