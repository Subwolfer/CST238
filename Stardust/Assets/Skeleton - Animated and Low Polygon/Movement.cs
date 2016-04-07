using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    static Animator anim;
    public float speed = 0.0f;
    public float walk = 10.0f;
    public float sprint = 15.0f;
    public float rotate = 5.0f;
    public float horizontal = Input.GetAxis("Horizontal");
    public float vertical = Input.GetAxis("Vertical");
    public bool move;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Rotate(0, horizontal * rotate, 0);

        if (vertical != 0 && !anim.GetBool("Normal_Attack")) 
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
                anim.SetBool("Normal_Attack", true);
                anim.SetBool("Running", false);
                anim.SetBool("Walking", false);
            }
        }
        else
        {
            anim.SetBool("Running", false);
            anim.SetBool("Walking", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Normal_Attack", true);
        }
	}
}
