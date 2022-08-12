using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalEnemyMovement : MonoBehaviour
{
    float timeElapsed;
    float lerpDuration = 3;
    Vector2 leftCoordinates;
    Vector2 rightCoordinates;
    // Start is called before the first frame update
    void Start()
    {
        leftCoordinates = transform.position;
    }

	void Update()
	{
		if (transform.position.x == leftCoordinates.x)
		{
			StartCoroutine(MoveRight());
		}
		else if (transform.position.x == rightCoordinates.x)
		{
			StartCoroutine(MoveLeft());
		}
	}

	IEnumerator MoveRight()
	{
		timeElapsed = Time.deltaTime;
		while (timeElapsed < lerpDuration)
		{
			transform.position = new Vector2(Mathf.Lerp(leftCoordinates.x, leftCoordinates.x - 5, timeElapsed / lerpDuration), leftCoordinates.y);
			timeElapsed += Time.deltaTime;
			yield return null;
		}
		transform.position = new Vector2(leftCoordinates.x - 5, leftCoordinates.y);
		rightCoordinates = transform.position;
	}

	IEnumerator MoveLeft()
	{
		timeElapsed = Time.deltaTime;
		while (timeElapsed < lerpDuration)
		{
			transform.position = new Vector2(Mathf.Lerp(rightCoordinates.x, rightCoordinates.x + 5, timeElapsed / lerpDuration), rightCoordinates.y);
			timeElapsed += Time.deltaTime;
			yield return null;
		}
		transform.position = new Vector2(rightCoordinates.x + 5, rightCoordinates.y);
		leftCoordinates = transform.position;
	}
}
