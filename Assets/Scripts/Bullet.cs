using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public Weapon weapon;
    public Renderer render;

    private float spawntime;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * weapon.bulletSpeed;
        spawntime = Time.time;
        render = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (Time.time - spawntime >= 10)
        {
            Color tempcolor = render.material.color;
            tempcolor.a = Mathf.MoveTowards(render.material.color.a, 0, 0.01f);
            render.material.color = tempcolor;
            if (tempcolor.a == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
