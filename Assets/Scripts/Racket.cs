using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour {
	// Movement Speed.
	public float speed = 150;

	// Called over and over again, but in a fixed time interval.
	void FixedUpdate () {
		// Get Horizontal Input
		float h = Input.GetAxisRaw("Horizontal");
		
		// Set Velocity (movement direction * speed)
		GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
	}
}
