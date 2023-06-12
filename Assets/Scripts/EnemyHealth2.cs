using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth2 : MonoBehaviour
{
    public int health = 100;
    public float respawnTime = 5f;
    private Vector3 startPosition;
    private Quaternion startRotation;

    private void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
        //StartCoroutine(Respawn());
        Respawn();
    }
/*
    private IEnumerator Respawn()
    {
        yield return new WaitForSeconds(respawnTime);
        health = 100;
        gameObject.SetActive(true);
        transform.position = startPosition;
        transform.rotation = startRotation;
    }
*/
    private void Respawn()
    {
        health = 100;
        gameObject.SetActive(true);
        transform.position = startPosition;
        transform.rotation = startRotation;
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "soldier")
        {
            EnemySoldier soldier = collision.gameObject.GetComponent<EnemySoldier>();
            soldier.TakeDamage(10);
        }
    }
    */
}

