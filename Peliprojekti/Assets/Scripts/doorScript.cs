using UnityEngine;
using System.Collections;

public class doorScript : MonoBehaviour {
    public GameObject door;
    public GameObject cover;
    public GameObject music;
    public GameObject bossmusic;
    private int counter;
    private bool started;
    public bool bossdoor;
    private GameObject gui;
    // Use this for initialization
    void Start () {
        counter = 0;
        gui = GameObject.FindGameObjectWithTag("guisystem");
    }
	
	// Update is called once per frame
	void FixedUpdate () {
	if(started)
        {
            if (GameObject.FindGameObjectWithTag("enemy") == null)
            {
                counter++;
                if (counter > 50)
                {
                    DestroyDoor();
                }

            }
        }
        
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player")) {
            
            
                CloseDoor();
            
                
        }
        
    }

    void CloseDoor()
    {
        door.SetActive(true);
        started = true;
        if(bossdoor)
        {
            music.SetActive(false);
            bossmusic.SetActive(true);
        }
        
    }

    void DestroyDoor()
    {
        Destroy(door);
        Destroy(cover);
        if(bossdoor)
        {
            gui.GetComponent<GUI_Script>().UpdateAnnouncer("");

            music.SetActive(true);
            bossmusic.SetActive(false);


        } else
        {
            gui.GetComponent<GUI_Script>().UpdateAnnouncer("Secret area is now open!");
        }
        
        started = false;
    }
}