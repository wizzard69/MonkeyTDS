using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float bulletSpeed;
    public float lifetime;
    public int bulletDamage;


    private void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
        lifetime -= Time.deltaTime;

        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            collision.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(bulletDamage);
            Destroy(gameObject);

        }
    }

}
