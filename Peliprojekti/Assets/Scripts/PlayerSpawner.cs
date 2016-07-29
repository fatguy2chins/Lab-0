using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {
    public GameObject playerPrefab;
	// Use this for initialization
	void Start () {
        SpawnPlayer();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {

    }
    public void SpawnPlayer()
    {
        Instantiate(playerPrefab, transform.position, transform.rotation);
        

    }
}
