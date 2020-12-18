using UnityEngine;

public class MoveLeft : MonoBehaviour
{
	private float speed = 30;
	private PlayerController playerControllerScript;
	private float leftBound = -15;
	private void Start()
	{
		playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
	}

	private void Update()
	{
		if (!playerControllerScript.gameOver)
			transform.Translate(Vector3.left * Time.deltaTime * speed);

		if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
			Destroy(gameObject);
	}
}