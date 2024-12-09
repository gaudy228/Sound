using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    private AudioSource deadBullet;
    void Start()
    {
        deadBullet = GameObject.FindWithTag("Dead").GetComponent<AudioSource>();
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Object"))
        {
            deadBullet.Play();
            Destroy(gameObject);
        }
    }
}
