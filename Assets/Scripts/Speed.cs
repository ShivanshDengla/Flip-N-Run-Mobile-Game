using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    //New
    
    public float speed;
    private Vector2 screenBounds;
    public GameObject effect;
    


    public int timeBtwSpawn;

    public float timer;
    public float decreaseTime = 1f;
    public float controlTimer;

    public float radius = 5f;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < screenBounds.x - 25)
        {
            Destroy(this.gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Explode();
            SoundManager.PlaySound("fastS");
            Destroy(gameObject);
        }
    }

    void Explode()
    {
         Debug.Log("Boom");
    }
}
