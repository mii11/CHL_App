using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {
	public GameObject coreObj;
	public int curHp = 100;
	int fullHp;
	int damageHp = 10;
	public Image hpGauge;
	GameObject hp;
	//	GameObject gun;
	//	Transform gunTransform;

	public float enemySpeed;

	//襲撃の間隔をあける
	float motionInterval;
	Animation enemyAnimation;
	BoxCollider enemyBoxCollider;
	SphereCollider coreCollider;
	bool isDead;

	void Start () {
		motionInterval = 0.0f;
		fullHp = curHp;
		isDead = false;
		enemyBoxCollider = GetComponent<BoxCollider> ();
		coreCollider = coreObj.GetComponent<SphereCollider> ();

		enemyAnimation = GetComponentInChildren<Animation>();

		hp = hpGauge.transform.parent.gameObject;
	}
	// Update is called once per frame
	void Update () {

		if (enemyAnimation == true) {
			if (curHp > 0) {
				switch (enemyAnimation.name) {
				case "SPIDER":
					enemyAnimation.Play ("Idle");
					break;
				case "":
					break;
				default:
					break;
				}
			}
		}
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "PlayerBullet") {
			curHp -= damageHp;
			hpGauge.fillAmount = (float)curHp / fullHp;
			if (curHp <= 0) {
				Die ();
			}
		}
	}

	void OnTriggerExit(Collider other){

	}

	public void Die(){
		if (isDead == false) {
			if (enemyAnimation == true) {
				switch (enemyAnimation.name) {
				case "SPIDER":
					enemyAnimation.Play ("Death");
					break;
//			case "":
//				break;
				default:
					break;
				}

			}
			Destroy (enemyBoxCollider);
			Destroy (coreCollider);
			Manager.instance.curEnemyNum -= 1;
			isDead = true;
		}
	}


	//要編集！敵の移動(規則正しく動きすぎ	)
	void Motion(){
		transform.Translate (-1 * transform.forward * Time.deltaTime * enemySpeed);	
		motionInterval += Time.deltaTime;
		print (motionInterval);

		print ("前");
		if ((motionInterval >= 0.8f) && (motionInterval < 1.4f)) {
			print ("右に移動");
			transform.Translate (Vector3.right * Time.deltaTime * enemySpeed);
			enemyAnimation.Play ("Walk");
		}else if ((motionInterval >= 1.4f) && (motionInterval < 2.0f)) {
			print ("左");
			transform.Translate (Vector3.left * Time.deltaTime * enemySpeed);
			enemyAnimation.Play ("Walk");
		}else if(motionInterval >= 2.0f){
			motionInterval = 0.0f;			
		} 

	}

	//要編集！うまく、いってない
	void HpPosition(){
		//positionではなく、向きを取得すること
		GameObject gun = Manager.instance.gun.GetComponent<GameObject> ().gameObject;
		print ("gun.name" + gun.name);

		Vector3 gunPos;
		gunPos.x = gun.transform.position.x;
		gunPos.y = gun.transform.position.y;
		gunPos.z = gun.transform.position.z;

//		gunPos.x = gunTransform.position.x;
//		gunPos.y = gunTransform.position.y;
//		gunPos.z = gunTransform.position.z;

		hpGauge.transform.parent.transform.position = gunPos;

	}


}
