using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private Rigidbody2D rb;
	public float mapWidth = 10f;
	public bool isGrounded = false;

	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		//Debug.Log(transform.position.x);
		var movement = FindObjectOfType<PlayerMovement>();
		//Mathf.Clamp(movement.x, -mapWidth, mapWidth);
	}

	private void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.gameObject.tag.Equals("Ground"))
		{
			isGrounded = true;
		}
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.tag.Equals("Ground"))
		{
			isGrounded = false;
		}
	}
}
