using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public int increase;
    public float speed;
    private Vector2 screenBounds;
    public GameObject effect;

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

            SoundManager.PlaySound("starS");
            Destroy(gameObject);
        }
    }
}
