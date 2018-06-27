using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }
    public IEnumerator RestartGameCo()
    {

        SoundManagerScript.Playsound("death");
        yield return new WaitForSeconds(1);
        Application.LoadLevel(Application.loadedLevel);
    

    }
}
