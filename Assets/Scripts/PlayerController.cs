﻿
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody playerRb;
	private void Start()
	{
		playerRb = GetComponent<Rigidbody>();
		playerRb.AddForce(Vector3.up * 1000);
	}

	private void Update()
	{

	}
}