using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class i_02_all : MonoBehaviour
{

    static string nextSecene_door = "j_01";
    static string nextSecene_dot = "k_01";

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
            if (hit.collider.gameObject.name == "i_02_door")
            {
                SceneManager.LoadScene(nextSecene_door);
            }
            if (hit.collider.gameObject.name == "i_02_dot")
            {
                SceneManager.LoadScene(nextSecene_dot);
            }

        }
    }
}
