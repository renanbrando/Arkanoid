using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public Canvas mainMenu;
    public Canvas optionsMenu;
    public static bool gameSound;
    public AudioSource music;

    private void Awake()
    {
        optionsMenu.enabled = false;
        playMusic();
    }

    public void OptionsOn()
    {
        mainMenu.enabled = false;
        optionsMenu.enabled = true;

    }

    public void Return()
    {
        mainMenu.enabled = true;
        optionsMenu.enabled = false;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Arkanoid");

    }

    public void Sound()
    {
        if(gameSound){
            stopMusic();

        } else {
            playMusic();
        }
    }

    void playMusic(){
        Menu.gameSound = true;
        music.Play();
        music.loop = true;
    }

    void stopMusic(){
        Menu.gameSound = false;
        music.Pause();
    }

    // Use this for initialization
    void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}
}
