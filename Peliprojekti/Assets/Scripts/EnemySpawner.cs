using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
    public GameObject enemyprefab;
    public bool spawnOnStart;
    public int startamount;
    public bool continuous_spawning;
    private int counter;
    public int speed;
    public int cont_amount;
    public bool randomAmout;
	// Use this for initialization
	void Start () {
        counter = 0;
	    if(spawnOnStart)
        {
            spawnEnemies(startamount);

        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void spawnEnemies(int amount)
    {
        for(int i=0;i< amount;i++)
        {

            Instantiate(enemyprefab,transform.position,transform.rotation);
        }
        
    }

    void FixedUpdate()
    {
        counter++;
        if(continuous_spawning && counter==speed)
        {
            if (randomAmout)
            {
                //cont_amount = Random.Range(2f, 6f);
            }
            for(int i2=0;i2< cont_amount;i2++)
            {
                Instantiate(enemyprefab, transform.position, transform.rotation);
            }
            
            counter = 0;
        }

    }
}
