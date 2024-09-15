using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float speed;
    public Transform bullet;

    void Start()
    {
        
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float newXPostition = transform.position.x + horizontalInput * speed;

        if (newXPostition > -10.25 && newXPostition < 10.25)
        {
            Vector2 movement = new Vector2(newXPostition, transform.position.y);
            transform.position = movement;
        }

        if (Input.GetKeyDown("space"))
        {
            Transform newBullet = Instantiate(bullet, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10);

            Destroy(newBullet.gameObject, 5);
        }
    }

}
