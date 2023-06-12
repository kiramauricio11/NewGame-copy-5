using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAttack : MonoBehaviour
{
    
        public int damage = 100;
        public float attackRange = 15f;
        public LayerMask enemyLayers;
    public float timeBetweenShots = 1;// 0.5f; // Add a time interval between shots

        private bool canShoot = true; // Add a boolean to track if we can shoot or not

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (canShoot)
                {
                    StartCoroutine(Shoot());
                }
            }
        }

        private IEnumerator Shoot()
        {
            canShoot = false; // Set the flag to false so we can't shoot again immediately
            Collider[] hitEnemies = Physics.OverlapSphere(transform.position, attackRange, enemyLayers);

            if (hitEnemies.Length > 0)
            {
                hitEnemies[0].GetComponent<EnemyHealth2>().TakeDamage(damage);
                Scoreboard.scoreCount += 1;
            }

            yield return new WaitForSeconds(timeBetweenShots); // Wait for the time interval before we can shoot again
            canShoot = true; // Set the flag to true so we can shoot again
        }
    

}




