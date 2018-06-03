using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_03 : MonoBehaviour
{

    public GameObject bowl_s;
    public GameObject bowl_m;
    public GameObject bowl_l;


    AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        bowl_s.gameObject.SetActive(false);
        bowl_m.gameObject.SetActive(false);
        bowl_l.gameObject.SetActive(false);


        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (!audioSource.isPlaying)
        {
            bowl_s.gameObject.SetActive(true);
            bowl_m.gameObject.SetActive(true);
            bowl_l.gameObject.SetActive(true);

        }

    }
}
