using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	public float enemyspeed;
	//襲撃の間隔をあける
	float motionInterval;
//	Animator anim;
	Animation enemyAnimation;
//	AnimationClip enemyMotionClip;
	public AnimationClip[] clips;

	void Start () {
		motionInterval = 0.0f;
//		anim = GetComponent<Animator> ();
		enemyAnimation = GetComponent<Animation> ();
		if (gameObject.name == "SPIDER") {
			enemyAnimation.PlayQueued ("Idle");
		}
	}
	// Update is called once per frame
	void Update () {
//		EnemyMotion ();
		if (gameObject.name == "SPIDER") {
			enemyAnimation.PlayQueued ("Idle");
		}
	
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "PlayerBullet") {
			if (gameObject.tag == "Enemy") {
//				anim.SetBool ("IsAttackedEnemy", true);
			}
		}
	}

	void OnTriggerExit(Collider other){

		if (other.gameObject.tag == "PlayerBullet") {
			if (gameObject.tag == "Enemy") {
//				anim.SetBool ("IsAttackedEnemy", false);
			}
		}
	}

	void EnemyMotion(){
		//敵の移動(規則正しく動く	)
		transform.Translate (-1 * transform.forward * Time.deltaTime * enemyspeed);	
		motionInterval += Time.deltaTime;
		print (motionInterval);

		print ("前");
		if ((motionInterval >= 0.8f) && (motionInterval < 1.4f)) {
			print ("右に移動");
			transform.Translate (Vector3.right * Time.deltaTime * enemyspeed);
		}else if ((motionInterval >= 1.4f) && (motionInterval < 2.0f)) {
			print ("左");
			transform.Translate (Vector3.left * Time.deltaTime * enemyspeed);
		}else if(motionInterval >= 2.0f){
			motionInterval = 0.0f;			
		} 

	}
}
