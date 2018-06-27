using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {


    private Rigidbody2D Rb;
    public Rigidbody2D PlayerRB;
 

	void Start () {
        Rb = this.GetComponent<Rigidbody2D>();
        PlayerRB = GameObject.Find("Megaman").GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerRB.velocity.x != 0 || PlayerRB.velocity.y != 0)
        {
            if (Rb.transform.position.x - PlayerRB.transform.position.x > 2.3f)
            {
                Rb.velocity = new Vector2(PlayerRB.velocity.x, PlayerRB.velocity.y);
            }
            else if(Rb.transform.position.x - PlayerRB.transform.position.x < -2.3f)
            {
                Rb.velocity = new Vector2(PlayerRB.velocity.x, PlayerRB.velocity.y);
            }
        }
        else
        {
            Rb.velocity = new Vector2(0, 0);
        }

	}
}