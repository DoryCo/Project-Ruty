﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_01 : MonoBehaviour
{

    public GameObject wind;
    public GameObject bed;
    public GameObject marked;

    AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        wind.gameObject.SetActive(false);
        bed.gameObject.SetActive(false);
        marked.gameObject.SetActive(false);

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (!audioSource.isPlaying)
        {
            wind.gameObject.SetActive(true);
            bed.gameObject.SetActive(true);
            marked.gameObject.SetActive(true);
        }

    }
}
