using UnityEngine;
using System.Collections;

public class doorScript : MonoBehaviour {
    public GameObject door;
    public GameObject cover;
    private int counter;
    private bool started;
	// Use this for initialization
	void Start () {
        counter = 0;
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
        print("door closed");
    }

    void DestroyDoor()
    {
        Destroy(door);
        Destroy(cover);
        print("door destroyed");
        started = false;
    }
}