using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expo02 : MonoBehaviour {

    public GameObject arr1;
    //static float audio_length = 9;
    //private float start_time;

    AudioSource audioSource;


	// Use this for initialization
	void Start () {
        arr1.gameObject.SetActive(false);
        //start_time = Time.time;

        audioSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
        //if (Time.time - start_time > audio_length)
        //{
        //    arr1.gameObject.SetActive(true);
        //}

        if (!audioSource.isPlaying)
        {
            arr1.gameObject.SetActive(true);
        }

	}
}
