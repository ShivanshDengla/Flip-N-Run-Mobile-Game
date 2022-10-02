using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    public GameObject RewardPanel;
    public GameObject spike;
    

    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        
    }

    public void ContinueGame()
    {
        
        Time.timeScale = 1;
        spike.GetComponent<BoxCollider2D>().enabled = false;
        RewardPanel.SetActive(false);
    }
}
