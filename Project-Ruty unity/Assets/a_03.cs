using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a_03 : MonoBehaviour
{

    public GameObject arr_r;
    public GameObject arr_l;


    AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        arr_r.gameObject.SetActive(false);
        arr_l.gameObject.SetActive(false);

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (!audioSource.isPlaying)
        {
            arr_r.gameObject.SetActive(true);
            arr_l.gameObject.SetActive(true);

        }

    }
}
