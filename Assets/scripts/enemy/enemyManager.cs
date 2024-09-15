using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    public Transform enemy;
    public float currentEnemys;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentEnemys = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (currentEnemys < 5)
        {
            Transform newEnemy = Instantiate(enemy, new Vector2(UnityEngine.Random.Range(-10.25f, 10.25f), UnityEngine.Random.Range(6f, 10f)), transform.rotation);
            newEnemy.GetComponent<Rigidbody2D>().velocity = new Vector2(0, UnityEngine.Random.Range(-5.00f, -0.1f));
            Destroy(newEnemy.gameObject, 3);
        }
    }
}
