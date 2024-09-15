using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            GameObject scoreManager = GameObject.Find("scoreManager");
            scoreManager.GetComponent<score>().AddScore(10);
            Destroy(gameObject);
        }
    }
}
