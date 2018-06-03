﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class a_01 : MonoBehaviour
{
    static string nextSecene = "a_02";

    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


        if (!audioSource.isPlaying)
        {
            SceneManager.LoadScene(nextSecene);
        }

    }
}
