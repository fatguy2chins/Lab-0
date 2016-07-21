using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{

    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;
    public Vector3 speed2 = new Vector2(10, 10);
    float inputX;
    float inputY;
    bool walking;
    Animator anim;


    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();


        rigidbodyComponent = GetComponent<Rigidbody2D>();
    }

    

    void FixedUpdate()
    {

        
            








        rigidbodyComponent.AddForce(movement * 4);

    }


    // Update is called once per frame
    void Update()
    {
        //WASD CONTROLS
        inputX = 0;
        inputY = 0;

        if (Input.GetKey("w"))
        {
            inputY = 1;
            anim.SetFloat("Speed", Mathf.Abs(2.0F));

        }

        if (Input.GetKey("a"))
        {
            inputX = -1;
            anim.SetFloat("Speed", Mathf.Abs(2.0F));
        }

        if (Input.GetKey("s"))
        {
            inputY = -1;
            anim.SetFloat("Speed", Mathf.Abs(2.0F));
        }

        if (Input.GetKey("d"))
        {
            inputX = 1;
            anim.SetFloat("Speed", Mathf.Abs(2.0F));
        }

        movement = new Vector2(speed2.x * inputX, speed2.y * inputY);

        //-anim


       

      


     if(Input.GetKey("w")==false && Input.GetKey("a") == false && Input.GetKey("s") == false && Input.GetKey("d") == false)
        {
            anim.SetFloat("Speed", 0);
        }
            
        






    }//update


}
