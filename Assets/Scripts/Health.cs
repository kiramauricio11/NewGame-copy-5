using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public AudioSource audioSource;

    //new
    private Vector3 startPosition;
    private Quaternion startRotation;

    public int health = 100;//new

    // Start is called before the first frame update
    void Start()
    {
       // currentHealth = maxHealth;

        // startPosition = new Vector3(-1, 0, -14); // Set the starting position to (0, 0, 0) //new lines 4/25/23 //Nvm don't need them
        // startRotation = Quaternion.identity; // Set the starting rotation to the identity quaternion //new lines 4/25/23 //Issue must have been currentHealth

        startPosition = transform.position;
        startRotation = transform.rotation;

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
            audioSource.Play();
        }
    }

    private void Die()
    { 
        gameObject.SetActive(false);
        //StartCoroutine(Respawn());
        Respawn();
    }

    private void Respawn()
    {
        health = 100;
        gameObject.SetActive(true);
        transform.position = startPosition;
        transform.rotation = startRotation;
    }

}
