using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreController : MonoBehaviour {
	Animator anim;
	public bool IsAttackCore;
	//	Animation animation;

	// Use this for initialization
	void Start () {
		IsAttackCore = false;
//		anim = GetComponent<Animator> ();	
	}
	
	void OnTriggerEnter(Collider other){
//		print ("CoreのColliderの中");

		if (other.gameObject.tag == "PlayerBullet") {
			if (gameObject.tag == "Core") {
				print ("Core にあたった");
				IsAttackCore = true;
//				anim.SetBool ("IsAttackCore", true);
			}
		}

	}
}
