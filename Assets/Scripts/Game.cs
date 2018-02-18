using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public AudioSource sound;
    public static int blocks;

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("gameSound", 0) == 1){
            sound.Play();
            sound.loop = true;
        }

        blocks = 36;
	}
	
	// Update is called once per frame
	void Update () {
        if (blocks <= 0){
            SceneManager.LoadScene("Menu");
        }
	}
}
