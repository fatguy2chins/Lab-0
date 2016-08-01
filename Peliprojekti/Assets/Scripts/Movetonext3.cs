using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Movetonext3 : MonoBehaviour {



	public void LoadStage()
	{
		SceneManager.LoadScene("1_endcutscene");

	}

	public void LoadStage2()
	{
		SceneManager.LoadScene("2_endcutscene");

	}

    public void BackToMenu()
    {
        SceneManager.LoadScene("0_Menu");
    }

}

