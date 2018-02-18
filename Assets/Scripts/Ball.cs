using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {
	// Movement Speed
	public float speed = 100.0f;
	public GameObject ball;
    public AudioSource sound;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter2D(Collision2D col) {
		// Hit the Paddle?
		if (col.gameObject.name == "paddle") {
            // Plsy sound 
            sound.Play();

			// Calculate hit Factor
			float x = hitFactor(transform.position,
				col.transform.position,
				col.collider.bounds.size.x);

			// Calculate direction, set length to 1
			Vector2 dir = new Vector2(x, 1).normalized;

			// Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        } else if (col.gameObject.name == "DeadZone"){
            SceneManager.LoadScene("Menu");
            //Instantiate(ball, new Vector3(0.0f, 0.0f, 0.0f), transform.rotation);
            Destroy(gameObject);
        }
	}


	float hitFactor(Vector2 ballPos, Vector2 racketPos,
		float racketWidth) {
		// ascii art:
		//
		// 1  -0.5  0  0.5   1  <- x value
		// ===================  <- paddle
		//
		return (ballPos.x - racketPos.x) / racketWidth;
	}
}
