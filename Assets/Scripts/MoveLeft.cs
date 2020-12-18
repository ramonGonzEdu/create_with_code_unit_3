using UnityEngine;

public class MoveLeft : MonoBehaviour
{
	private float speed = 30;
	private PlayerController playerControllerScript;
	private void Start()
	{
		playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
	}

	private void Update()
	{
		if (!playerControllerScript.gameOver)
			transform.Translate(Vector3.left * Time.deltaTime * speed);
	}
}