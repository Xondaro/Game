using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour {

    public Text Scoreboard;
    public GameObject Ball;
    public int Bat_1_Score = 0;
    public int Bat_2_Score = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Ball.transform.position.x >= 11f)
        {
            Bat_1_Score += 1;
        }
        if (Ball.transform.position.x <= -11f)
        {
            Bat_2_Score += 1;
        }

        Scoreboard.text = Bat_1_Score.ToString() + " - " + Bat_2_Score.ToString();

        print(Bat_1_Score + " , " + Bat_2_Score);
    }
}
