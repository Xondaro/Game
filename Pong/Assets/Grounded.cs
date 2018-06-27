using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour {

    private Player_Control Player;
	void Start () {

        Player = gameObject.GetComponentInParent<Player_Control>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Bot")
        {
            Player.grounded = true;
        }
        if(collision.gameObject.name == "Left Wall")
        {
            Player.wallL = true;

        }
        if (collision.gameObject.name == "Right")
        {
            Player.wallR = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Left Wall")
        {
            Player.wallL = false;

        }
        if (collision.gameObject.name == "Right")
        {
            Player.wallR = false;

        }
    }
}

