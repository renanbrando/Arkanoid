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

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            Vector2 touchPosition = Input.GetTouch(0).position;
            double halfScreen = Screen.width / 2.0;

            //Check if it is left or right?
            if (touchPosition.x < halfScreen)
            {
                //gameObject.transform.Translate(Vector2.left * speed * Time.deltaTime);
                GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
            }
            else if (touchPosition.x > halfScreen)
            {
                //gameObject.transform.Translate(Vector2.right * speed * Time.deltaTime);
                GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
            }

        }

	}


}
