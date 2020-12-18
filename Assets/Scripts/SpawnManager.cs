using UnityEngine;

public class SpawnManager : MonoBehaviour
{

	public GameObject obstaclePrefab;
	private Vector3 spawnPos = new Vector3(30, 0, 0);

	private float startDelay = 2;
	private float repeatRate = 2;
	private PlayerController playerControllerScript;
	private void Start()
	{
		playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
		InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
	}

	private void SpawnObstacle()
	{
		if (!playerControllerScript.gameOver)
			Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
	}

	private void Update()
	{

	}
}
