using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    private Vector2 screenBounds;
    public GameObject effect;
    public bool DisableCollider = false;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if(DisableCollider == true)
        {
        }

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

            other.GetComponent<PlayerController>().health -= damage;
            Debug.Log(other.GetComponent<PlayerController>().health);

            SoundManager.PlaySound("dieS");
            Destroy(gameObject);
        }

        
    }

}
