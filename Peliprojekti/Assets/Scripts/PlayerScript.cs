using UnityEngine;
using System.Collections;

using UnityEngine.UI;
public class PlayerScript : MonoBehaviour
{

    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;
    public Vector3 speed2 = new Vector2(10, 10);
    float inputX;
    float inputY;
    bool walking;
    Animator anim;
    public AudioClip hurtsound;
    public int health;
    private AudioSource audioSource;
    private GameObject gui;
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    private bool hasKeyToNextLevel;
    // Use this for initialization
    void Start()
    {
        gui = GameObject.FindGameObjectWithTag("guisystem");//guisystem must have tag!


        audioSource = gameObject.GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        rigidbodyComponent = GetComponent<Rigidbody2D>();

        
    }//start




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



        if (health < 1)
        {

            gui.GetComponent<GUI_Script>().UpdateAnnouncer("DEAD");
            gui.GetComponent<GUI_Script>().EnableRespawn();
            gui.GetComponent<GUI_Script>().EnableHealth();
            //GameObject.FindGameObjectWithTag("restart_btn").SetActive(true);
            Time.timeScale = 0.0f;
            Destroy(gameObject);
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            //
        }

        //----------------Spell controls---------------------

        if(Input.GetKeyUp("1"))
        {
            transform.Find("BasicSpell").gameObject.SetActive(true);
            transform.Find("FireGun").gameObject.SetActive(false);
            transform.Find("IceSpell").gameObject.SetActive(false);
        }
        if(Input.GetKeyUp("2"))
        {

            transform.Find("FireGun").gameObject.SetActive(true);
            transform.Find("BasicSpell").gameObject.SetActive(false);
            transform.Find("IceSpell").gameObject.SetActive(false);
        }
        if (Input.GetKeyUp("3"))
        {

            transform.Find("IceSpell").gameObject.SetActive(true);
            transform.Find("BasicSpell").gameObject.SetActive(false);
            transform.Find("FireGun").gameObject.SetActive(false);
        }

        //-----------------esc handler---------------



    }//update

    public void Damage(int amount)
    {
        health = health - amount;
        
        if (hurtsound != null)
        {
            audioSource.clip = hurtsound;
            audioSource.Play();
        }

        gui.GetComponent<GUI_Script>().UpdateHealth(health);

    }//damage

    public void Heal(int healamount)
    {
        health = health + healamount;
        gui.GetComponent<GUI_Script>().UpdateHealth(health);
    }

    public void GiveKey()
    {
        hasKeyToNextLevel = true;
    }
    public bool HasKey()
    {
        if(hasKeyToNextLevel)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
