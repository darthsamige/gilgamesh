using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float maxSpeed = 6.0f;
	public float moveHorizontal;
	public float moveVertical;
	private Rigidbody2D body;

	void Awake() {
		body = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate() {
		body.velocity = new Vector2(moveHorizontal * maxSpeed, moveVertical * maxSpeed);
	}

	void Update() {
		moveHorizontal = Input.GetAxis("Horizontal");
		moveVertical = Input.GetAxis("Vertical");
	}
}
