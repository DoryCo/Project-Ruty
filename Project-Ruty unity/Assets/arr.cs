using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arr : MonoBehaviour {

    public AudioClip pig;
    public AudioClip laugh;
    private AudioSource source;
    private float lowPitchRange = .75F;
    private float highPitchRange = 1.5F;
    private float velToVol = .2F;

    [Header("Animation")]
    [SerializeField] string isPressed;
    private int press;
    private Animator animator;

    public int counterY;
    public bool pressed;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        press = Animator.StringToHash(isPressed);
        animator.SetBool(press, false);
	}
	
	// Update is called once per frame
	void Update () {
        animator.SetBool(press, false);
        if (Input.GetMouseButtonDown(0)) {
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
            if (hit.collider.gameObject.name == "yellow")
            {
                pressed = true;
                animator.SetBool(press, true);
                source.pitch = Random.Range(lowPitchRange, highPitchRange);
                counterY++;
                if (counterY - 8 == 0)
                {
                    source.PlayOneShot(laugh, velToVol);
                    counterY = 0;
                }
                else
                {
                    source.PlayOneShot(pig, velToVol);
                }
            }
        }
    }

}
