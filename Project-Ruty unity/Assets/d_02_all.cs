using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class d_02_all : MonoBehaviour
{

    static string nextSecene_S = "e_01";
    static string nextSecene_M = "d_03";
    static string nextSecene_L = "d_04";

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
            if (hit.collider.gameObject.name == "d_02_s")
            {
                SceneManager.LoadScene(nextSecene_S);
            }
            if (hit.collider.gameObject.name == "d_02_m")
            {
                SceneManager.LoadScene(nextSecene_M);
            }
            if (hit.collider.gameObject.name == "d_02_l")
            {
                SceneManager.LoadScene(nextSecene_L);
            }
        }
    }
}
