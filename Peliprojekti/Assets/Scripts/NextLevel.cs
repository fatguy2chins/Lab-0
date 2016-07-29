using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{

    private GameObject gui;
    public bool getFireSpell;
    public bool getNewSpell;
    public bool getNewSpell2;
    public string nextLevel;
    public bool needsKey;
    private int counter;
        private bool StartCounter;
    void Start()
    {
        gui = GameObject.FindGameObjectWithTag("guisystem");
        StartCounter = false;
        counter = 0;
    }

// Update is called once per frame
void FixedUpdate()
{
        if(StartCounter)
        {
            if (counter > 200)
            {
                SceneManager.LoadScene(nextLevel);
            }
            counter++;
        }
        



    }
void OnTriggerEnter2D(Collider2D collider)
{
    if (collider.CompareTag("Player"))
    {


        if(needsKey)
            {

                if (collider.GetComponent<PlayerScript>().HasKey() == true)
                {
                    gui.GetComponent<GUI_Script>().UpdateAnnouncer("LEVEL COMPLETE");
                    StartCounter = true;




                }
                else
                {
                    print("you dont have a key!");
                }


            } else
            {
                gui.GetComponent<GUI_Script>().UpdateAnnouncer("LEVEL COMPLETE");
                StartCounter = true;
            }
        

    }

}//ontriggerenter



}



