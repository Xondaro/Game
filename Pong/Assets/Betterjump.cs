using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Betterjump : MonoBehaviour {

    public float fallmult = 2.5f;
    public float lowjumpmult = 2f;
    private Rigidbody2D Rb;


	// Use this for initialization
	void Awake () {
        Rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Rb.velocity.y < 0)
        {
            Rb.velocity += Vector2.up * Physics2D.gravity.y * (fallmult - 1) * Time.deltaTime;
        }
	}
}
