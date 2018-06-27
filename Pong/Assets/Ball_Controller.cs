using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour {

    // Use this for initialization
    private Rigidbody2D Rb;
    public float ballspeed = 8;
    public GameObject Bat_1;
    public GameObject Bat_2;
    public Restart theRestart;
    private GameObject restartg;
    
    private GameObject sons;
	void Start () {
        restartg = GameObject.Find("GameManager");
        Rb = this.GetComponent<Rigidbody2D>();
        Rb.velocity = new Vector2(ballspeed, ballspeed);
        Bat_1 = GameObject.Find("Pad1");
        Bat_2 = GameObject.Find("Pad2");
	}
	
	// Update is called once per frame
	void Update () {

        if (this.transform.position.x >= 10f)
        {
            SoundManagerScript.Playsound("placar");
            this.transform.position = new Vector3(0f, 0f, 0f);
        }
        if (this.transform.position.x <= -10f)
        {
            SoundManagerScript.Playsound("placar");
            this.transform.position = new Vector3(0f, 0f, 0f);
        }
        Physics2D.IgnoreLayerCollision(8, 11);
        Physics2D.IgnoreLayerCollision(8, 9);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name == "Pad1")
        {
           SoundManagerScript.Playsound("paddle");
            if (Bat_1.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                Rb.velocity = new Vector2(ballspeed, ballspeed);
            }
            else if (Bat_1.GetComponent<Rigidbody2D>().velocity.y < -0.5f){
                Rb.velocity = new Vector2(ballspeed, -ballspeed);
            }
            else
            {
                Rb.velocity = new Vector2(ballspeed, 0);
            }
        }
        if (collision.gameObject.name == "Pad2")
        {
            SoundManagerScript.Playsound("paddle");

            if (Bat_2.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                Rb.velocity = new Vector2(-ballspeed, ballspeed);
            }
            else if (Bat_2.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                Rb.velocity = new Vector2(-ballspeed, -ballspeed);
            }
            else
            {
                Rb.velocity = new Vector2(-ballspeed, 0);
            }
        }
        if (collision.gameObject.name == "Top" || collision.gameObject.name == "Bot")
        {
            SoundManagerScript.Playsound("wall");
        }
        if (collision.gameObject.name == "Megaman")
        {
        
            StartCoroutine(restartg.GetComponent<Restart>().RestartGameCo());
        }

    }
}
