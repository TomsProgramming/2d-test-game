using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("jaja");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("janee");
    }
}
