using UnityEngine;
using System.Collections;

public class EnemyTest : MonoBehaviour {

    public float speed;

    public GameObject target;
    public Transform target_transform;
    public int health = 100;
    public int power;
    public bool randomSpeed;
    public float maxSpeed;
    public float minSpeed;
    private int counter;
    private Vector2 rand_pos;
    public bool CanDropHP;
    public float HPDropChance;
    public GameObject healthObjectPrefab;
    public GameObject keyObjectPrefab;
    private float rand;
    public bool DropsKeyOnDeath;
    // Use this for initialization
    void Start () {
        
        target = GameObject.FindGameObjectWithTag("Player");
        if(target != null)
        {
            target_transform = target.transform;
        }
        if(randomSpeed)
        {
            speed = Random.Range(minSpeed, maxSpeed);

        }
        rand_pos = new Vector2(Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f));
        counter = 0;

        rand = Random.Range(0f, 100f);
	}
	
	// Update is called once per frame
	void Update () {


        //gameObject.transform.LookAt(target_transform);
        

	}
    void FixedUpdate()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        //gameObject.transform.position += transform.up * speed * Time.deltaTime;
        //gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-2,0), ForceMode2D.Force);


        if(target!=null) {
            Vector2 tar_pos = target.transform.position;
            if (counter>10)
            {
                if(Random.Range(1.0f,2.0f)>1.0f)
                {
                    rand_pos = new Vector2(Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f));
                }
                
                counter = 0;
            }
            tar_pos = tar_pos + rand_pos;

            transform.position = Vector2.MoveTowards(transform.position, tar_pos, speed * Time.deltaTime);

            counter++;
  
        }
        
        if(health<1)
        {
            if (CanDropHP && rand < HPDropChance)
            {
                Instantiate(healthObjectPrefab, transform.position, transform.rotation);
            }
            if(DropsKeyOnDeath)
            {
                Instantiate(keyObjectPrefab, transform.position, transform.rotation);
            }
            Destroy(gameObject);

        }
        gameObject.GetComponentInChildren<TextMesh>().text = "HP:"+health;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if(collider.CompareTag("Player"))
        {
            collider.GetComponent<PlayerScript>().Damage(power);

        }

    }
    public void Damage(int damage)
    {
        health = health - damage;
    }
}
