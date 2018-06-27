using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour {

    public Rigidbody2D Rb;
    public bool grounded;
    public bool wallL;
    private bool virou = true;
    public bool wallR;
    public float movespeed = 5;
    public float jumpspeed = 8;
    public float fallspeed = 70;
	// Use this for initialization
	void Start () {
        Rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Rb.velocity.x == 0 && Rb.velocity.y == 0)
        {
            if (Rb.transform.localScale.x > 0)
            {
                Rb.transform.localScale = new Vector3 (-Rb.transform.localScale.x, Rb.transform.localScale.y, 1);
            }
            else
            {
                Rb.transform.localScale = new Vector3(Rb.transform.localScale.x, Rb.transform.localScale.y, 1);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (wallR == false)
            {
                if(Rb.transform.localScale.x < 0)
                {
                Rb.transform.localScale = new Vector3(-Rb.transform.localScale.x, Rb.transform.localScale.y, 1);
                }
                Rb.velocity = new Vector2(movespeed, Rb.velocity.y);
            } 
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (wallL == false)
            {
                if (Rb.transform.localScale.x > 0)
                {
                    Rb.transform.localScale = new Vector3(-Rb.transform.localScale.x, Rb.transform.localScale.y, 1);
                }
                Rb.velocity = new Vector2(-movespeed, Rb.velocity.y);
            }
        }
        else
        {
         
            Rb.velocity = new Vector2(0, Rb.velocity.y);
        }
        if (Input.GetButtonDown("Jump") && grounded == true){
            SoundManagerScript.Playsound("pulo");
            grounded = false;
            Rb.velocity = new Vector2(Rb.velocity.x, jumpspeed);
        }
        Physics2D.IgnoreLayerCollision(12, 9);
	}
}
