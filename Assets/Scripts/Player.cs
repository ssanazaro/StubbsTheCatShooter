using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private Rigidbody2D rb;
	public float speed = 5f;
	public float mapWidth = 10f;
	public float jumpAmount = 10f;
	public bool direction;
	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		{
			//if (Time.time > powerUpTimer + 5f)
			//{
			//	rb.GetComponent<Renderer>().material.color = Color.white;
			//	jumpAmount = 10;
			//}
			if (Input.GetKeyDown(KeyCode.Space))
			{
				//if (isGrounded == true)
				//{
					Jump();
				//}
			}
			var movement = HandleMovement();
			Mathf.Clamp(movement.x, -mapWidth, mapWidth);
		}
	}

	private void Jump()
	{
		rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
	}

	Vector2 HandleMovement()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			FlipLeft();
			return rb.velocity = new Vector2(-speed, rb.velocity.y);
		}
		else
		{
			if (Input.GetKey(KeyCode.RightArrow))
			{
				FlipRight();
				return rb.velocity = new Vector2(+speed, rb.velocity.y);
			}
			else
			{
				return rb.velocity = new Vector2(0, rb.velocity.y);
			}
		}
	}

	private void FlipLeft()
	{
		if (transform.rotation.y > 0)
		{
			transform.Rotate(0f, 180f, 0f);
			direction = false;
		}
	}

	private void FlipRight()
	{
		if (transform.rotation.y <= 0)
		{
			transform.Rotate(0f, 180f, 0f);
		}
	}

	//private void PlayerDirection()
	//{
	//	if (Input.GetKey(KeyCode.LeftArrow && transform))
	//	{
	//		transform.Rotate
	//	}
	//}
}
