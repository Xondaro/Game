using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count_Score : MonoBehaviour {

    // Use this for initialization
    public Text Scoreboard;
    public GameObject ball;
    private int Bat_1_Score = 0;
    private int Bat_2_Score = 0;

	void Start () {
        ball = GameObject.Find("Ball");

		
	}
	
	// Update is called once per frame
	void Update () {
        if (ball.transform.position.x >= 9.9f)
        {
            Bat_1_Score++;
        }
        if (ball.transform.position.x <= -9.9f)
        {
            Bat_2_Score++;
        }

        Scoreboard.text = Bat_1_Score.ToString() + " - " + Bat_2_Score.ToString();

        
	}
}
