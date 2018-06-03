using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class e_03 : MonoBehaviour
{
    static string nextSecene = "a_04";

    private float start_time;


    // Use this for initialization
    void Start()
    {
        start_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {


        if (Time.time - start_time > 2)
        {
            SceneManager.LoadScene(nextSecene);
        }

    }
}
