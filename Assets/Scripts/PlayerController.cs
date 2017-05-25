using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speedX;
	public float speedY;
	public float speedZ;

	void Update () {
		float vertical = Input.GetAxis ("Vertical");
		float horizontal = Input.GetAxis ("Horizontal");


		//失敗		if (Input.GetKey ("up") == true) || (Input.GetKey ("down") == true) {
		if (Input.GetKey ("up")) {
			MoveForwardBaclward(vertical);
		}

		if (Input.GetKey ("down")) {
			MoveForwardBaclward(vertical);
		}

		if (Input.GetKey ("right")) {
			MoveRightLeft(horizontal);
		}

		if (Input.GetKey ("left")) {
			MoveRightLeft(horizontal);
		}


	}

	void MoveForwardBaclward(float vertical){
		transform.Translate (0, 0, vertical * speedZ); 
	}

	void MoveRightLeft(float horizontal){
		transform.Translate (horizontal * speedX, 0, 0);
	}

}
