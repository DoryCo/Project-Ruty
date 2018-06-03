using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d_02 : MonoBehaviour
{

    public GameObject bed_s;
    public GameObject bed_m;
    public GameObject bed_l;


    AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        bed_s.gameObject.SetActive(false);
        bed_m.gameObject.SetActive(false);
        bed_l.gameObject.SetActive(false);


        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (!audioSource.isPlaying)
        {
            bed_s.gameObject.SetActive(true);
            bed_m.gameObject.SetActive(true);
            bed_l.gameObject.SetActive(true);

        }

    }
}
