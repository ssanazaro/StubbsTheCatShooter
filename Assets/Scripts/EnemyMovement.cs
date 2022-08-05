using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    float timeElasped;
    float lerpDuration = 5;
	// Update is called once per frame
	void Update()
    {
		//Debug.Log(timeElasped);
		if (timeElasped < lerpDuration)
		{
            transform.position = new Vector2(Mathf.Lerp(transform.position.x, 5, timeElasped / lerpDuration), transform.position.y);
            timeElasped += Time.deltaTime;
        }
        //FindPlayer();

        //if (player.transform.position.x > transform.position.x - 5)
        //{
            //Debug.Log("Player is nearby");
            //transform.position = Mathf.Lerp(transform.position.x, transform.position.x, 5);
            //transform.position = new Vector2(Mathf.Lerp(transform.position.x, player.transform.position.x, timeElasped), transform.position.y);


        //}
    }

    //  private void FindPlayer()
    //  {
    //      Debug.Log("Looking for player");
    //      //Debug.Log(player.transform.position.x);
    //      if (player.transform.position.x > transform.position.x - 5)
    //{
    //          Debug.Log("Player is nearby");
    //          //transform.position = Mathf.Lerp(transform.position.x, transform.position.x, 5);
    //          transform.position = new Vector2(Mathf.Lerp(transform.position.x, player.transform.position.x, timeElasped), transform.position.y);
    //}
    //  }
}
