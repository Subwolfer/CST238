using UnityEngine;
using System.Collections;

public class Skelton_Movement : MonoBehaviour {

    public float mov_speed = 2.5f;
    public float back_speed = 1.0f;
    public float side_speed = 0.5f;
    public float rotate_speed = 25.0f;
    public float lock_pos = 0.0f;
    Animator animator;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Quaternion.Euler(lock_pos, transform.rotation.eulerAngles.y, lock_pos);

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Run", true);
            transform.position += transform.forward * Time.deltaTime * mov_speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Back", true);
            transform.position -= transform.forward * Time.deltaTime * back_speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Left", true);
            transform.position -= transform.right * Time.deltaTime * side_speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Right", true);
            transform.position += transform.right * Time.deltaTime * side_speed;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0.0f, -rotate_speed * Time.deltaTime, 0.0f);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0.0f, rotate_speed * Time.deltaTime, 0.0f);
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Run", false);
            animator.SetBool("Back", false);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
        }
    }
}
