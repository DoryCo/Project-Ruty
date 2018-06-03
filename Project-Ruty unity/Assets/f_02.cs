using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_02 : MonoBehaviour
{

    public GameObject wind;
    public GameObject bed;

    private float start_time;
    AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        start_time = Time.time;
        wind.gameObject.SetActive(false);
        bed.gameObject.SetActive(false);

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (!audioSource.isPlaying && (Time.time - start_time > 1))
        {
            wind.gameObject.SetActive(true);
            bed.gameObject.SetActive(true);

        }

    }
}
