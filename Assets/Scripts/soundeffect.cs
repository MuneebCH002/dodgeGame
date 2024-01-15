using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundeffect : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1;

    public void button1()
    {
        src.clip = sfx1;
        src.Play();
    }
}
