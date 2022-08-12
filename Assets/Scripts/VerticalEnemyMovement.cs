using System.Collections;
using UnityEngine;

public class VerticalEnemyMovement : MonoBehaviour
{
	GameObject enemy;
    float timeElapsed;
    float lerpDuration = 3;
    Vector2 downCoordinates;
    Vector2 upCoordinates;

	void Start()
	{
        downCoordinates = transform.position;
	}

	void Update()
    {
		if (transform.position.y == downCoordinates.y)
		{
			StartCoroutine(MoveUp());
		}
		else if (transform.position.y == upCoordinates.y)
		{
			StartCoroutine(MoveDown());
		}
	}

	IEnumerator MoveUp()
	{
		timeElapsed = Time.deltaTime;
		while (timeElapsed < lerpDuration)
		{
			transform.position = new Vector2(downCoordinates.x, Mathf.Lerp(downCoordinates.y, downCoordinates.y + 5, timeElapsed / lerpDuration));
			timeElapsed += Time.deltaTime;
			yield return null;
		}
		transform.position = new Vector2(downCoordinates.x, downCoordinates.y + 5);
		upCoordinates = transform.position;
	}

	IEnumerator MoveDown()
    {
		timeElapsed = Time.deltaTime;
		while (timeElapsed < lerpDuration)
        {
            transform.position = new Vector2(upCoordinates.x, Mathf.Lerp(upCoordinates.y, upCoordinates.y - 5, timeElapsed / lerpDuration));
            timeElapsed += Time.deltaTime;
			yield return null;
		}
		transform.position = new Vector2(upCoordinates.x, upCoordinates.y - 5);
		downCoordinates = transform.position;
	}
}
