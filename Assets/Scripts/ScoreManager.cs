using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject tutorial;

    public float increastPerSecond;
    public float score;
    public Text scoreDisplay;
    public Text highScore;
    
    

    public int show;


    void Start()
    {
        if (PlayerPrefs.GetInt("HighScore", 0) <= 2)
        {
            tutorial.SetActive(true);
        }
        increastPerSecond = 1f;
        score = 0;
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    private void Update()
    {
        
        score += increastPerSecond * Time.deltaTime * 10f;
        show = (int)score;
        scoreDisplay.text = show.ToString();
        if (show > PlayerPrefs.GetInt("HighScore", 0))
        {
            
            PlayerPrefs.SetInt("HighScore", show);
            highScore.text = show.ToString();
        }


    }

   
}