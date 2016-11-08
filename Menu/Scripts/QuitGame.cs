/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public bool isLevel = false;

    public GameObject fader;
    public GameObject menuParent;
    public AudioSource pauseMenuSound;
    //public static AudioClip pauseMenuSound;


    public void OnMouseUp()
    {
        #if UNITY_STANDALONE
            Application.Quit();
        #endif

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void Resume()
    {
        if (isLevel == true && Time.timeScale == 0)
        {
            Time.timeScale = 1;

            fader.SetActive(false);
            menuParent.SetActive(false);
        }
    }

    public void TopCornerPause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0; // pause

            fader.SetActive(true);
            menuParent.SetActive(true);
        }
        else
        {
            Time.timeScale = 1; // unpause

            fader.SetActive(false);
            menuParent.SetActive(false);
        }
        
    }

    public void MainMenuLoad(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    void Update()
    {
        if (isLevel == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

                if (Time.timeScale == 1)
                {
                    Time.timeScale = 0; // pause

                    fader.SetActive(true);
                    menuParent.SetActive(true);

                    //AudioSource.PlayClipAtPoint(pauseMenuSound, new Vector3(0,0,0));
                    pauseMenuSound.Play();
                }
                else
                {
                    Time.timeScale = 1; // unpause
                    
                    fader.SetActive(false);
                    menuParent.SetActive(false);
                }
            }

            if (Time.timeScale == 1)
            {
                pauseMenuSound.Pause();
            }
            
        }
    }
}
