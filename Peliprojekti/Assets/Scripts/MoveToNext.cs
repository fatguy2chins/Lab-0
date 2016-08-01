using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveToNext : MonoBehaviour {


    public void LoadStage()
    {
        SceneManager.LoadScene("1_cutscene");

    }

    public void LoadStage2()
    {
        SceneManager.LoadScene("2_cutscene");

    }

    public void LoadStage3()
    {
        SceneManager.LoadScene("3_cutscene");

    }

    public void LoadStage4()
    {
        SceneManager.LoadScene("4_cutscene");

    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level1_Woods");

    }

   


}
