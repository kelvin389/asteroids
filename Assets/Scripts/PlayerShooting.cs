using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform firePoint;
    public Weapon weapon;

    private float lastShot;

    void Start()
    {
        lastShot = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (Time.time - lastShot >= weapon.fireDelay/100)
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
