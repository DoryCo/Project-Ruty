using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class e_01 : MonoBehaviour
{

    public GameObject wind;
    public GameObject bed;


    AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        wind.gameObject.SetActive(false);
        bed.gameObject.SetActive(false);

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (!audioSource.isPlaying)
        {
            wind.gameObject.SetActive(true);
            bed.gameObject.SetActive(true);

        }

    }
}
