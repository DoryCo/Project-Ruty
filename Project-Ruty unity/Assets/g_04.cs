using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g_04 : MonoBehaviour
{

    public GameObject etgar;
    public GameObject men;
    public GameObject marked;

    AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        etgar.gameObject.SetActive(false);
        men.gameObject.SetActive(false);
        marked.gameObject.SetActive(false);

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (!audioSource.isPlaying)
        {
            etgar.gameObject.SetActive(true);
            men.gameObject.SetActive(true);
            marked.gameObject.SetActive(true);
        }

    }
}
