using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DropDownChangeMusic : MonoBehaviour 
{
    public Dropdown changeMusic;
    public AudioClip[] musicListe;

    AudioSource music;

    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    void Update()
    {

    }
    public void Changer()
    {
        if (changeMusic.value == 0)
        {
            music.clip = musicListe[0];
            music.Play();
        }

        if (changeMusic.value == 1)
        {
            music.clip = musicListe[1];
            music.Play();
        }

        if (changeMusic.value == 2)
        {
            music.clip = musicListe[2];
            music.Play();
        }
        /*switch (changeMusic.value)
        {
            case 0:
                music.clip = musicListe[0];
                music.Play();
                break;
            case 1:
                music.clip = musicListe[1];
                music.Play();
                break;
            case 2:
                music.clip = musicListe[2];
                music.Play();
                break;
        }*/
    }
}
