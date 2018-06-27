using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {


    public static AudioClip padhit, wallhit, playerhit, score, jumpsound;
    public float wallvol;
    static AudioSource audioSrc;
    void Start() {
        padhit = Resources.Load<AudioClip>("pong_colision");
        wallhit = Resources.Load<AudioClip>("table_colision");
        playerhit = Resources.Load<AudioClip>("levar_dano");
        score = Resources.Load<AudioClip>("ponto");
        jumpsound = Resources.Load<AudioClip>("vader_pulo");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
      

    }
    public static void Playsound (string clip)
    {
        switch (clip)
        {
            case "paddle":
                audioSrc.PlayOneShot(padhit);
                break;
            case "wall":
                audioSrc.PlayOneShot(wallhit);
                break;
            case "death":
                audioSrc.PlayOneShot(playerhit);
                break;
            case "placar":
                audioSrc.PlayOneShot(score);
                break;
            case "pulo":
                audioSrc.pl(jumpsound);
                break;

        }
    }
}