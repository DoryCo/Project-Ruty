using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class d_04 : MonoBehaviour
{
    static string nextSecene = "f_04";

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
