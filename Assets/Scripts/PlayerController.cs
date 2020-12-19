
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody playerRb;
	public float jumpForce = 200;
	public float gravityModifier = 1;
	public bool isOnGround = true;
	public bool gameOver = false;
	private Animator playerAnim;
	private void Start()
	{
		playerRb = GetComponent<Rigidbody>();
		Physics.gravity *= gravityModifier;
		playerAnim = GetComponent<Animator>();
	}

	private void Update()
	{
		if ((Input.GetKeyDown(KeyCode.Space) || (Application.isEditor && Input.GetKeyDown(KeyCode.O))) && isOnGround && !gameOver)
		{
			playerAnim.SetTrigger("Jump_trig");
			playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
			isOnGround = false;
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
			isOnGround = true;
		else if (collision.gameObject.CompareTag("Obstacle"))
		{
			gameOver = true;
			Debug.Log("Game Over");
			playerAnim.SetBool("Death_b", true);
			playerAnim.SetInteger("DeathType_int", 1);
		}

	}
}