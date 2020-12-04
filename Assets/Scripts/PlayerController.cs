
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody playerRb;
	private void Start()
	{
		playerRb = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) || (Application.isEditor && Input.GetKeyDown(KeyCode.O)))
		{
			playerRb.AddForce(Vector3.up * 1000);

		}
	}
}