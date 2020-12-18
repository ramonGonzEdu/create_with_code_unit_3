using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
	private Vector3 startPos;
	private float repeadWidth;
	private void Start()
	{
		startPos = transform.position;
		repeadWidth = GetComponent<BoxCollider>().size.x / 2;
	}

	private void Update()
	{
		if (transform.position.x < startPos.x - repeadWidth)
		{
			transform.position = startPos;
		}
	}
}