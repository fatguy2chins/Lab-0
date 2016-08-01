using UnityEngine;
using System.Collections;

public class DestroyOnHit : MonoBehaviour {
    public bool Explosion;
    public GameObject expPrefab;
    public int damage;
    public bool destroyOnhit;
    public bool freezeOnHit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //is shot?
        /*ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
        if (shot != null)
        {
            if (shot.isEnemyShot != isEnemy)
            {
                Damage(shot.damage);
                Destroy(shot.gameObject);
            }

        }*/

        if(otherCollider.CompareTag("enemy")){
            otherCollider.GetComponent<EnemyTest>().Damage(damage);

            if (freezeOnHit)
            {
                otherCollider.GetComponent<EnemyTest>().SetFrozenSpeed();

            }
        }

        if(destroyOnhit)
        {
            Destroy(gameObject);
        }
        

        if (Explosion)
        {
            Instantiate(expPrefab, transform.position, transform.rotation);
        }

        
        

        

    }//ontriggerenter2D
}
