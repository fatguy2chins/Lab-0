using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pickup : MonoBehaviour {
    public bool isHealth;
    public int HealAmount;
    public bool isKeyToNextLevel;
    public bool isSpoon;

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
            if(isSpoon)
            {
                SceneManager.LoadScene("0_endcutscene");
            }
            Destroy(gameObject);
        }
    }
}