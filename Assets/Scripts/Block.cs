using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D collisionInfo) {
		// Destroy the whole Block
		// Destroy(this) would only destroy the Block Script component. 
		// If we want to destroy the whole Block, 
		// then we always have to use Destroy(gameObject)
		Destroy(gameObject);
	}
}
