using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//NEW
public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    

    public bool flip;
    public float jumpForce = 1f;
    public int health = 3;
    
    public GameObject heart1, heart2, heart3;

    private int extraJump;
    public int extraJumpValue;
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    public GameObject spike;
    public GameObject go;
    public GameObject endGame;
    public GameObject pauseButton;

    




    void Start()
    {
        

        Time.timeScale = 1f;
        pauseButton.SetActive(true);
        spike.GetComponent<BoxCollider2D>().enabled = true;

        extraJump = extraJumpValue;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        if (health <= 0)
        {
            
            endGame.SetActive(true);
            health = 3;
        }
        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;

            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;

            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;

            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                
                endGame.SetActive(true);
                health = 3;
                break;
        }

    }


    public void jump()
    {
        if (isGrounded == true)
        {
            extraJump = extraJumpValue;
        }

        if (extraJump > 0)
        {
            if (rb.gravityScale > 0)
            {
                SoundManager.PlaySound("jumpS");
                rb.velocity = new Vector2(0, jumpForce);
            }
            else
            {
                SoundManager.PlaySound("jumpS");
                rb.velocity = new Vector2(0, -jumpForce);
            }

            extraJump--;
        }
        else if (extraJump == 0 && isGrounded == true)
        {
            if (rb.gravityScale > 0)
            {
                SoundManager.PlaySound("jumpS");
                rb.velocity = new Vector2(0, jumpForce);
            }
            else
            {
                SoundManager.PlaySound("jumpS");
                rb.velocity = new Vector2(0, -jumpForce);
            }
        }
    }

    public void rotate()
    {
        rb.gravityScale *= -1;
        if (flip == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180f);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }

        flip = !flip;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Speed"))
        {
            spike.GetComponent<BoxCollider2D>().enabled = false;
            go.SetActive(true);
            DestroySpikeOnScreen();
        }
    }

    public void DestroySpikeOnScreen()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach (GameObject enemy in enemies)
        GameObject.Destroy(enemy);
    }
}