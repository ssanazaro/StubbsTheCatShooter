using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public float bulletTimer = 0;
    public float bulletLife = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        bulletTimer = Time.time;
    }

	private void Update()
	{
		if (Time.time > bulletTimer + bulletLife)
		{
            Destroy(gameObject);
		}
	}

	private void OnTriggerEnter2D(Collider2D hitInfo)
	{
		if (hitInfo.tag.Equals("Enemy"))
		{
            Destroy(gameObject);
        }
    }
}
