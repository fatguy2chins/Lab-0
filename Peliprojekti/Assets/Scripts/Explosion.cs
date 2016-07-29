using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{
    private float calc;
    public float exp_radius;
    Collider2D[] objects;
    Vector2 collisionpoint;
    private Vector2 loc;
    public AudioClip sound;
    public int damage;
    void Start()
    {
        calc = 0;

        objects = Physics2D.OverlapCircleAll(gameObject.transform.position, 1.5f);
        loc = transform.position;









        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i].GetComponent<Rigidbody2D>() == null)
            {
            }
            else
            {
                if (objects[i].CompareTag("enemy"))
                {
                    objects[i].GetComponent<EnemyTest>().Damage(damage);

                }
                objects[i].GetComponent<Rigidbody2D>().AddForceAtPosition((objects[i].transform.position - transform.position).normalized * 30 * Time.smoothDeltaTime, loc, ForceMode2D.Impulse);
            }

            //objects[i].GetComponent<Rigidbody2D>().AddForce(new Vector2(10,10));
        }



        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        if (sound != null)
        {
            audioSource.clip = sound;
            audioSource.volume = 0.5f;
            audioSource.Play();
        }

    }//start

        
    void Update()
    {

        
    }//update
    void FixedUpdate()
    {
        if(calc>100)
        {
            Destroy(gameObject);

        }
        calc = calc + 5;

        
    }

}