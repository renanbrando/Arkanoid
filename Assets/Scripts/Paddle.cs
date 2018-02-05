using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	// Movement Speed
	public float speed = 150;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		// Get Horizontal Input
		float h = Input.GetAxisRaw("Horizontal");

		// Set Velocity (movement direction * speed)
		GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
	}
}
