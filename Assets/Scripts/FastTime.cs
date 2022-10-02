using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastTime : MonoBehaviour
{
    public float timeLeft;
    public float decreaseTime;
    public float timeNew;
    public GameObject end;

    public GameObject spike;

    // Start is called before the first frame update
    void Start()
    {
        timeNew = timeLeft;

    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft >= 0)
        {
            spike.GetComponent<BoxCollider2D>().enabled = false;
            Time.timeScale = 3f;
            timeLeft -= decreaseTime;
            
        }
        else
        {
            Time.timeScale = 1f;
            timeLeft = timeNew;
            end.SetActive(false);
            spike.GetComponent<BoxCollider2D>().enabled = true;
        }

    }
}
