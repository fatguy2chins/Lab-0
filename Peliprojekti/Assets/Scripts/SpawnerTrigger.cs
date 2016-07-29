using UnityEngine;
using System.Collections;

public class SpawnerTrigger : MonoBehaviour {
    // Use this for initialization
    public bool spawnOnce;
    public int amount;
    private int counter;
	void Start () {
        counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            
            if (counter < 1)
            {
                gameObject.GetComponent<EnemySpawner>().spawnEnemies(amount);
            }
            if (spawnOnce)
            {
                counter++;
            }

        }
    }
}
