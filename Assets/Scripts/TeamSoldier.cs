using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamSoldier : MonoBehaviour
{
    /*
    public float speed = 3.0f;
    public Transform EnemySoldier;
    public float currentHealth; // the current health of the enemy


    void Update()
    {
        transform.LookAt(EnemySoldier);

        transform.position += transform.forward * speed * Time.deltaTime;

    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage; // reduce the current health by the amount of damage taken
    }

    */

    public float speed = 3.0f;
    public Transform EnemySoldier;
    public float currentHealth; // the current health of the enemy
    
    private Animator anim;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {
        transform.LookAt(EnemySoldier);

        transform.position += transform.forward * speed * Time.deltaTime;

        anim.SetBool("running", true);

    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage; // reduce the current health by the amount of damage taken
    }
}
