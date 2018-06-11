using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class g_04_all : MonoBehaviour
{

    static string nextSecene_E = "i_01";
    static string nextSecene_M = "h_01";

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
            if (hit.collider.gameObject.name == "g_04_etgar")
            {
                SceneManager.LoadScene(nextSecene_E);
            }
            if (hit.collider.gameObject.name == "g_04_men")
            {
                SceneManager.LoadScene(nextSecene_M);
            }

        }
    }
}
