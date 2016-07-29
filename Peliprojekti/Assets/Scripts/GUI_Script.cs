using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUI_Script : MonoBehaviour {

    public Text hpText;
    public GameObject player;
    public Text anno;
    public Button res;
    // Use this for initialization
    void Start () {
        
        hpText.text = "HP: " + player.GetComponent<PlayerScript>().health;
        showHelp();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
    }

    public void UpdateHealth(int hp)
    {

        hpText.text = "HP: " + hp;
    }
    public void UpdateAnnouncer(string text)
    {
        anno.text = text;

    }
    public void Restart()
    {
        print("level restarted");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void EnableRespawn()
    {
        res.gameObject.SetActive(true);

    }

    public void showHelp()
    {
        //GameObject.Find("HelpPanel").SetActive(true);

    }
    public void CloseHelp()
    {


    }
    public void EnableHealth()
    {
        GameObject.Find("hpText").SetActive(false);
    }
}
