using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class g_03 : MonoBehaviour
{
    static string nextSecene = "g_04";

    AudioSource audioSource;

    private float start_time;

    // Use this for initialization
    void Start()
    {
        start_time = Time.time;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


        if (!audioSource.isPlaying && (Time.time - start_time > 1))
        {
            SceneManager.LoadScene(nextSecene);
        }

    }
}
