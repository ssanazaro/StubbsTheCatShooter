using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject enemyBulletPrefab;
    float timer;

	void Start()
	{
		timer = Time.time + 3;
	}
	// Update is called once per frame
	void Update()
    {
		if (timer > Time.time)
		{
			Shoot();
		}
    }

	void Shoot()
	{
		Instantiate(enemyBulletPrefab, firepoint.position, firepoint.rotation);
	}
}
