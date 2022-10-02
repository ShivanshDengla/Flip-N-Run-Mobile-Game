using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip jumpS, flipS, dieS, starS, fastS;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        jumpS = Resources.Load<AudioClip>("jumpS");
        flipS = Resources.Load<AudioClip>("flipS");
        dieS = Resources.Load<AudioClip>("dieS");
        starS = Resources.Load<AudioClip>("starS");
        fastS = Resources.Load<AudioClip>("fastS");

        audioSrc = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "jumpS":
                audioSrc.PlayOneShot(jumpS);
                break;

            case "flipS":
                audioSrc.PlayOneShot(flipS);
                break;

            case "dieS":
                audioSrc.PlayOneShot(dieS);
                break;

            case "starS":
                audioSrc.PlayOneShot(starS);
                break;

            case "fastS":
                audioSrc.PlayOneShot(fastS);
                break;


        }
    }


}
