using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {
    public bool isHealth;
    public int HealAmount;
    public bool isKeyToNextLevel;
	// Use this for initialization
	void Start () {
	    

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {

            if(isHealth)
            {
                collider.GetComponent<PlayerScript>().Heal(HealAmount);
            }
            if(isKeyToNextLevel)
            {
                collider.GetComponent<PlayerScript>().GiveKey();
            }
            
            Destroy(gameObject);
        }
    }
}