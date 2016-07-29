using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{

    public GameObject settingsPanel;

    public GameObject Canvas;
    public GameObject Camera;
    bool Paused = false;





    public void showSettingsPanel()
    {
        settingsPanel.SetActive(true);
    }

    public void hideSettingsPanel()
    {
        settingsPanel.SetActive(false);
    }



    void start()
    {

        Canvas.gameObject.SetActive(false);

        hideSettingsPanel();
    }




    // Use this for initialization
    public void StartGame()
    {
        SceneManager.LoadScene("Level1_Woods");
    }

    //Exit the game
    public void ExitGame()
    {
        {
            Application.Quit();
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (Paused == true)
            {
                Time.timeScale = 1.0f;
                Canvas.gameObject.SetActive(false);
                // Screen.showCursor = false;
                //Screen.lockCursor = true;
                //Camera.audio.Play();
                Paused = false;
            }
            else {
                Time.timeScale = 0.0f;
                Canvas.gameObject.SetActive(true);
                // Screen.showCursor = true;
                // Screen.lockCursor = false;
                // Camera.audio.Pause();
                Paused = true;
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        Canvas.gameObject.SetActive(false);
        // Screen.showCursor = false;
        // Screen.lockCursor = true;
        // Camera.audio.Play();
        Paused = false;
    }


}
