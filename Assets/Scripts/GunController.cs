using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
	public GameObject bullet;
	float bulletInterval;

	void start(){
		bulletInterval = 0.0f;
	}

	// Update is called once per frame
	void Update () {

		bulletInterval += Time.deltaTime;
		if(Input.GetKeyDown(KeyCode.Space)){
			print ("spaceキーおした（１）");
			if (bulletInterval >= 0.2f){
				GenerateBullet ();	
			}
		}

	}

	void GenerateBullet(){
		bulletInterval = 0.0f;
		Instantiate (bullet, transform.position, Quaternion.identity);
	}
}
