using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour {

    public Text score;
    public AudioSource sound;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D collisionInfo) {
        // Destroy the whole Block 
        sound.Play();

        score.text = (int.Parse(score.text) + 1).ToString();

		Destroy(gameObject);
	}
}
