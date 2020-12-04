
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody playerRb;
	public float jumpForce = 200;
	public float gravityModifier = 1;
	private void Start()
	{
		playerRb = GetComponent<Rigidbody>();
		Physics.gravity *= gravityModifier;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) || (Application.isEditor && Input.GetKeyDown(KeyCode.O)))
		{
			playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

		}
	}
}