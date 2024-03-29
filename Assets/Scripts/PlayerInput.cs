using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Mirror;

public class PlayerInput : NetworkBehaviour
{
	private Rigidbody rb;
	// Get speed from unity
	public float speed;
	private float movementX;
	private float movementY;
	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	void OnMove(InputValue value)
	{
		if (!isLocalPlayer)
		{
			return;
		}
		Vector2 v = value.Get<Vector2>();

		movementX = v.x;
		movementY = v.y;
	}

	// Update is called once per frame
	private void FixedUpdate()
	{
		if (isLocalPlayer)
		{
			Vector3 movement = new Vector3(movementX, 0.0f, movementY);
			rb.AddForce(movement * speed);
		}
	}
}