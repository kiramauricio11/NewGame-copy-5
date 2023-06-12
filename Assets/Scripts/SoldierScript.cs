using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class SoldierScript : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    private float yrot = 0;
    private float speed = .2f;

    //public float timeBetweenShots;


    //public float sensitivity = 5.0f;
    //public Transform playerCamera;

    void Start()
    {
        anim = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            RaycastHit hit;
            // check if moving forward in the distance of speed*5
            // will hit anything, if will not hit anything, animate running and move
            // otherwise stop animating running and not move
            if (rb.SweepTest(transform.forward, out hit, speed * 5) == false)
            {
                anim.SetBool("running", true);
                transform.position = transform.position + transform.forward * speed;
            }
            else
            {
                anim.SetBool("running", false);
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            RaycastHit hit;
            // check if moving backward in the distance of speed*5 will hit anything
            // if will not hit anything, animate running and move
            // otherwise stop animating running and not move
            if (rb.SweepTest(-transform.forward, out hit, speed * 5) == false)
            {
                anim.SetBool("running", true);
                transform.position = transform.position - transform.forward * speed;
            }
            else
                anim.SetBool("running", false);
        }
        else  // no W key or S key pressed
        {
            anim.SetBool("running", false);
        }

        
        if (Input.GetKey(KeyCode.A))
        {
            yrot -= 2.0f; // in degree
            Quaternion targetRotation = Quaternion.Euler(0, yrot, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation,
        targetRotation, Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.D))
        {
            yrot += 2.0f; // in degree
            Quaternion targetRotation = Quaternion.Euler(0, yrot, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation,
        targetRotation, Time.deltaTime * 10);
        }


    }
}
