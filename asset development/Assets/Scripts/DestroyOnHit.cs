using UnityEngine;
using System.Collections;

public class DestroyOnHit : MonoBehaviour {
    public GameObject expPrefab;
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

        Destroy(gameObject);
        Instantiate(expPrefab, transform.position, transform.rotation);
    }
}
