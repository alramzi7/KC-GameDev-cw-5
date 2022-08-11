using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        GetComponent<AudioSource>().Play();
    }
}
