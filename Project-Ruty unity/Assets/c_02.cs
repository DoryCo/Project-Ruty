using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class c_02 : MonoBehaviour
{
    static string nextSecene = "b_03_s";

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
