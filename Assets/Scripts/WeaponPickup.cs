using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public Weapon weapon;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController playerController = collision.GetComponent<PlayerController>();
            PlayerShooting firePoint = playerController.GetComponentInChildren<PlayerShooting>();

            firePoint.weapon = weapon;

            Destroy(gameObject);
        }
    }
}
