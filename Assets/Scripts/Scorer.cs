using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hit=-1;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "hits") { 
        hit++;
        Debug.Log("you are hitting " +hit);
        }

    }
}
