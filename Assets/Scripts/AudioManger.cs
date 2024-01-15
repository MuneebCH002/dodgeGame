using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManger : MonoBehaviour
{
    public sound[] musicsounds, sfxsounds;
    public AudioSource musicsource, sfxsource;
    public static AudioManger instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void playmusic(string name)
    {
        sound s=Array.Find(musicsounds,x =>x.name==name);
        if (s==null) {
            Debug.Log("music not found");
         
        }
        else
        {
            musicsource.clip=s.clip;
            musicsource.Play();
        }
    }
    public void Start()
    {
        playmusic("theme");
    }
    public void PlaySfx(string name)
    {
        sound s = Array.Find(sfxsounds, x => x.name == name);
        if (s == null)
        {
            Debug.Log("music not found");

        }
        else
        {
            sfxsource.PlayOneShot(s.clip);
        }
    }
}
