using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_1_Controller : MonoBehaviour {
    public float padspeed = 5;
    private Rigidbody2D Rb;
    private GameObject RbBall;
    public Restart theRestart;
    private GameObject restartg;
    // Use this for initialization
    void Start () {
        restartg = GameObject.Find("GameManager");
        Rb = this.GetComponent<Rigidbody2D>();
        RbBall = GameObject.FindGameObjectWithTag("Ball");
	}
	
	// Update is called once per frame
	void Update () {
        if (Rb.transform.position.y < RbBall.transform.position.y && RbBall.transform.position.x < 0)
        {
            Rb.velocity = new Vector2(0f, padspeed);
        }
        else if (Rb.transform.position.y > RbBall.transform.position.y && RbBall.transform.position.x < 0)
        {
            Rb.velocity = new Vector2(0f, -padspeed);
        }
        else
        {
            Rb.velocity = new Vector2(0f, 0f);

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Megaman")
        {
            StartCoroutine(restartg.GetComponent<Restart>().RestartGameCo());
        }
    }
}
