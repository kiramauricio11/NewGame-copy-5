using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShooter : MonoBehaviour
{ 
    public Transform player;
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float timeBetweenShots;
    private float shotTime;


    private Vector3 position, target;//new
    private Quaternion rotation;//new
    //private float nextFire, cooldown_time = 0.1f;//new


    [SerializeField] ParticleSystem particles = null;



    //new
    public int damage = 100;
    public float attackRange = 15.0f;//I guess it starts and can change on unity
    public LayerMask enemyLayers;

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < 10f)
        {
            if (Time.time > shotTime)
            {
                shotTime = Time.time + timeBetweenShots;
                Shoot();
            }
        }

        /*
            // Check if there is an enemy within the attack range
            Collider[] hitEnemies = Physics.OverlapSphere(transform.position, attackRange, enemyLayers);
            if (hitEnemies.Length > 0)
            {
                // Damage the first enemy hit
                hitEnemies[0].GetComponent<Health>().TakeDamage(damage);
                //hitEnemies[0].GetComponent<EnemyHealth1>().TakeDamage(damage);

                //Scoreboard.scoreCount += 1;
            }

        */
        
    }

    void Shoot()
    {
       //Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        //new lines from here
       // Vector3 direction = (target - position);
        //direction = direction.normalized;
        //var rotation = Quaternion.LookRotation(direction);
        //var psShape = particles.shape;
        //psShape.rotation = rotation.eulerAngles - this.transform.rotation.eulerAngles;
        particles.Emit(10);

        // Check if there is an enemy within the attack range
        Collider[] hitEnemies = Physics.OverlapSphere(transform.position, attackRange, enemyLayers);
        if (hitEnemies.Length > 0)
        {
            // Damage the first enemy hit
            hitEnemies[0].GetComponent<Health>().TakeDamage(damage);
            //hitEnemies[0].GetComponent<EnemyHealth1>().TakeDamage(damage);

            //Scoreboard.scoreCount += 1;
            Scoreboard.EscoreCount += 1;
        }
    }

}

