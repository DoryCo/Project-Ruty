using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class i_02 : MonoBehaviour
{

    public GameObject door;
    public GameObject dot;
    public GameObject marked;

    private float start_time;

    AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        door.gameObject.SetActive(false);
        dot.gameObject.SetActive(false);
        marked.gameObject.SetActive(false);

        start_time = Time.time;

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (!audioSource.isPlaying && (Time.time - start_time > 1))
        {
            door.gameObject.SetActive(true);
            dot.gameObject.SetActive(true);
            marked.gameObject.SetActive(true);
        }

    }
}
