﻿using UnityEngine;

public class SpawnManager : MonoBehaviour
{

	public GameObject obstaclePrefab;
	private Vector3 spawnPos = new Vector3(30, 0, 0);

	private float startDelay = 2;
	private float repeatRate = 2;
	private void Start()
	{
		InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
	}

	private void SpawnObstacle()
	{
		Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
	}

	private void Update()
	{

	}
}
