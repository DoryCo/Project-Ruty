using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
            
public class expo01 : MonoBehaviour {
    static string nextSecene = "01_expo_2";
    static float audio_length = 9;
    private float start_time;


	// Use this for initialization
	void Start () {
        start_time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - start_time > audio_length)
        {
            SceneManager.LoadScene(nextSecene);
        }
	}
}
