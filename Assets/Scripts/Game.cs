using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public AudioSource sound;

	// Use this for initialization
	void Start () {
        if (Menu.gameSound){
            sound.Play();
            sound.loop = true;
        }	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
