using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject player;
    public float attackRange = 5.0f;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(transform.position, player.transform.position) <= attackRange)
        {
            Attack();
        }

        void Attack()
        {

            Instantiate(bulletPrefab, firePoint.transform.position, firePoint.rotation);
        }
    }
}
