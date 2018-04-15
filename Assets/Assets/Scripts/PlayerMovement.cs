using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody2D _rigidBody;
	public float playerSpeed;
	
	// Use this for initialization
	void Start () {
		this._rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateHorizontalSpeed();
		UpdateVerticalSpeed();
	}

	private void UpdateHorizontalSpeed()
	{
		var horizontalaAxisInput = Input.GetAxisRaw(StaticNames.Axes.HORIZONTAL);
		_rigidBody.velocity = new Vector2(
			horizontalaAxisInput > 0 ? this.playerSpeed 
				: horizontalaAxisInput < 0 ? -playerSpeed : 0
			, _rigidBody.velocity.y);
	}

	private void UpdateVerticalSpeed()
	{
		var verticalAxisInput = Input.GetAxisRaw(StaticNames.Axes.VERTICAL);
		_rigidBody.velocity = new Vector2(
			_rigidBody.velocity.x
			, verticalAxisInput > 0 ? this.playerSpeed 
				: verticalAxisInput < 0 ? -playerSpeed : 0
		);
	}
}
