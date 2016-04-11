using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    static Animator anim;
    public double time;
    public float speed = 0.0f;
    public float walk = 10.0f;
    public float sprint = 15.0f;
    public float rotate = 5.0f;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        time += Time.deltaTime;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Rotate(0, horizontal * rotate, 0);

        if (vertical != 0 && !anim.GetBool("Quick_Attack") && !anim.GetBool("Normal_Attack")) 
        {
            if (Input.GetKey(KeyCode.LeftShift))
                speed = sprint;
            else
                speed = walk;

            transform.Translate(0.0f, 0.0f, vertical * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("Running", true);
            }
            else
            {
                anim.SetBool("Walking", true);
                anim.SetBool("Running", false);
            }


            if (Input.GetKey(KeyCode.Space))
            {
                if (Random.Range(0, 10) <= 3)
                {
                    anim.SetBool("Quick_Attack", true);
                }
                else
                {
                    anim.SetBool("Normal_Attack", true);
                }

                anim.SetBool("Running", false);
                anim.SetBool("Walking", false);
            }
        }
        else
        {
            anim.SetBool("Running", false);
            anim.SetBool("Walking", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            time = 0;

            if (Random.Range(0, 10) <= 3)
            {
                anim.SetBool("Quick_Attack", true);
            }
            else
            {
                anim.SetBool("Normal_Attack", true);
            }
        }

        if (time > 1.07)
        {
            anim.SetBool("Quick_Attack", false);

            if (time > 3)
            {
                anim.SetBool("Normal_Attack", false);
            }
        }
	}
}
