using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform firePoint;
    public Weapon weapon;

    private float lastShot;
    private float num;

    void Start()
    {
        lastShot = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        num = Random.Range(1, 10);

        if (num > 5f)
        {
            if (Time.time - lastShot >= weapon.fireDelay / 100)
            {
                Shoot();
                lastShot = Time.time;
            }
        }
    }

    void Shoot()
    {
        Instantiate(weapon.bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
