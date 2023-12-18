using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = player.transform.position;
        Vector3 difference = playerpos - transform.position;
        difference.z = 0;

        float differenceTotal = difference.x + difference.y;

        float cameraSpeed = Mathf.Abs(differenceTotal / 2) + 3.5f;

		//transform.Translate(difference * cameraSpeed * Time.fixedDeltaTime);
		transform.Translate(difference);
    }
}
