using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{
    private float calc;
    public float exp_radius;
    Collider2D[] objects;
    Vector2 collisionpoint;
    private Vector2 loc;
    void Start()
    {
        calc = 0;

        objects = Physics2D.OverlapCircleAll(gameObject.transform.position, 1.5f);
        loc = transform.position;
        }//start

        
    void Update()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i].GetComponent<Rigidbody2D>() == null)
            {
            } else
            {
                objects[i].GetComponent<Rigidbody2D>().AddForceAtPosition((objects[i].transform.position - transform.position).normalized * 20 * Time.smoothDeltaTime, loc,ForceMode2D.Impulse);
            }
            
            //objects[i].GetComponent<Rigidbody2D>().AddForce(new Vector2(10,10));
        }
        
    }
    void FixedUpdate()
    {
        if(calc>100)
        {
            Destroy(gameObject);

        }
        calc = calc + 50;

        
    }
}