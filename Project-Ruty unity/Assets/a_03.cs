using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a_03 : MonoBehaviour
{

    public GameObject arr_r;
    public GameObject arr_l;

    private float start_time;

    AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        arr_r.gameObject.SetActive(false);
        arr_l.gameObject.SetActive(false);

        start_time = Time.time;
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (!audioSource.isPlaying && (Time.time - start_time > 1))
        {
            arr_r.gameObject.SetActive(true);
            arr_l.gameObject.SetActive(true);

        }

    }
}
