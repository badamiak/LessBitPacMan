using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_FollowsPlayer : MonoBehaviour {

	public Rigidbody2D player;
	private Transform thisTranform;
	// Use this for initialization
	void Start () {
		this.thisTranform = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		this.thisTranform.position = new Vector3(this.player.position.x,this.player.position.y,this.thisTranform.position.z);
	}
}
