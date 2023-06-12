using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySoldier : MonoBehaviour
{
    public float speed = 3.0f;
    public Transform Soldier_demo ;
    public float currentHealth; // the current health of the enemy *********MIGHT USE THIS; MEANING IMPORTANT**********

    private Animator anim;

    //  private Rigidbody rb; // rigidbody of the bullet
    /*
     void Start()
     {
         rb = GetComponent<Rigidbody>(); // get the rigidbody component

     }
    */

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {
        transform.LookAt(Soldier_demo);

        transform.position += transform.forward * speed * Time.deltaTime;

        anim.SetBool("running", true);

    }

    //*********MIGHT USE THIS; MEANING IMPORTANT**********
    
    public void TakeDamage(float damage)
    {
        currentHealth -= damage; // reduce the current health by the amount of damage taken
    }
    
}