using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    public playerController player;
    public float enemySpeed;
    Rigidbody rb;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        player = FindObjectOfType<playerController>();
	}
	
	void Update ()
    {
        transform.LookAt(player.transform.position);
	}

    private void FixedUpdate()
    {
        rb.velocity = (transform.forward * enemySpeed);


    }
}
