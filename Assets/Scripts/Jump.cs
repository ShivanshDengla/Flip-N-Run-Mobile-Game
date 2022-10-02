using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour

{
    public PlayerController player;
    
    // Start is called before the, first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    { 

    }

    public void makePlayerJump()
    {
        
        player.jump();
    }

}


