using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float rotateSpeed;
    public float speed;
    public float boostSpeed;
    public float boostCooldown;

    private float lastBoost;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastBoost = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && Time.time - lastBoost >= boostCooldown)
        {
            rb.AddForce(transform.right * boostSpeed * Time.fixedDeltaTime);
            lastBoost = Time.time;
        }
        if (Input.GetButton("Fire2"))
        {
            rb.AddForce(transform.right * speed * Time.fixedDeltaTime);
        }
        if (Input.GetButton("Fire3"))
        {
            rb.velocity = rb.velocity * 0.99f;
        }
        else
        {
            rb.velocity = rb.velocity * 0.997f;
        }

        LookAtMouse();
    }

    void LookAtMouse()
    {
		Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
		Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed * Time.fixedDeltaTime);
		//transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotateSpeed * Time.fixedDeltaTime);
		Debug.Log(rotation);

	}
}
