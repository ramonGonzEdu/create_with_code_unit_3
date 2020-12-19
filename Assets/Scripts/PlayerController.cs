
using UnityEngine;

[RequireComponent(typeof(Rigidbody)), RequireComponent(typeof(AudioSource))]
public class PlayerController : MonoBehaviour
{
	private Rigidbody playerRb;
	public float jumpForce = 200;
	public float gravityModifier = 1;
	public bool isOnGround = true;
	public bool gameOver = false;
	private Animator playerAnim;

	public ParticleSystem explosionParticle;
	public ParticleSystem dirtParticle;

	public AudioClip jumpSound;
	public AudioClip crashSound;
	private AudioSource playerAudio;
	private void Start()
	{
		playerRb = GetComponent<Rigidbody>();
		Physics.gravity *= gravityModifier;
		playerAnim = GetComponent<Animator>();
		playerAudio = GetComponent<AudioSource>();
	}

	private void Update()
	{
		if ((Input.GetKeyDown(KeyCode.Space) || (Application.isEditor && Input.GetKeyDown(KeyCode.O))) && isOnGround && !gameOver)
		{
			playerAnim.SetTrigger("Jump_trig");
			playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
			isOnGround = false;
			dirtParticle.Stop();
			playerAudio.PlayOneShot(jumpSound, 1.0f);
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			isOnGround = true;
			dirtParticle.Play();
		}
		else if (collision.gameObject.CompareTag("Obstacle"))
		{
			explosionParticle.Play();
			playerAudio.PlayOneShot(crashSound, 1.0f);
			gameOver = true;
			Debug.Log("Game Over");
			playerAnim.SetBool("Death_b", true);
			playerAnim.SetInteger("DeathType_int", 1);
			dirtParticle.Stop();
		}

	}
}