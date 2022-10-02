using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    
   public GameObject tut;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0; 
    }

    public void Begin()
    {
        Time.timeScale = 1;
        
        tut.SetActive(false);
    }
    
}
