using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class expo_2_arr_r : MonoBehaviour
{

    static string nextSecene = "01_expo_3";

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            print("Pressed left click, casting ray.");
            CastRay();
        }
    }

    void CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        if (hit)
        {
            print(hit.collider.gameObject.name);
            if (hit.collider.gameObject.name == "ArrowRight_01")
            {
                SceneManager.LoadScene(nextSecene);
            }
        }
    }
}
