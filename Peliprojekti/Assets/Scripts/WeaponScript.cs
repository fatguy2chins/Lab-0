using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {

    public GameObject shotPrefab;
    public float shootingRange;
    public AudioClip shotsound;
    private float shootCooldown;
    public float shotspeed;

    // Use this for initialization
    void Start () {
        shootCooldown = 0f;
        
    }
	
	// Update is called once per frame
	void Update () {
	    if(shootCooldown>0)
        {

            shootCooldown -= Time.deltaTime;
        }

        bool shoot = Input.GetButton("Fire1");
        shoot |= Input.GetButtonDown("Fire2");

        if (shoot)
        {
            WeaponScript weapon = GetComponent<WeaponScript>();
            if (weapon != null)
            {
                weapon.Attack();

            }

        }


    }//update

    public void Attack()
    {
        if(CanAttack)
        {
            shootCooldown = shootingRange;


            //create new shot

            AudioSource audioSource = gameObject.AddComponent<AudioSource>();
            if(shotsound!=null)
            {
                audioSource.clip = shotsound;
                audioSource.volume=0.3f;
                audioSource.Play();
            }


            GameObject shot = (GameObject)Instantiate(shotPrefab, transform.position,transform.rotation);
            Rigidbody2D body = shot.GetComponent<Rigidbody2D>();
            body.AddRelativeForce(new Vector2(50*shotspeed,0));
            
            //assign position
            //shotTransform.position = transform.position;



        }//if canattack



    }//attack

    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0f;
        }

    }

}
