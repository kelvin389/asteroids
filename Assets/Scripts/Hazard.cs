using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public float damage;

    private float lastHitTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hitPlayer(collision);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        hitPlayer(collision);
    }

    private void hitPlayer(Collider2D player)
    {
        if (player.CompareTag("Player"))
        {
            PlayerStats stats = player.GetComponent<PlayerStats>();
            if (Time.time - lastHitTime >= stats.invulnerableTime)
            {
                stats.health -= damage;
                lastHitTime = Time.time;
            }
        }
    }
}
