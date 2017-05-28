using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour {
	public GameObject bullet;
	public Camera playerCamera;
	public float speed = 20;

	//	Ray ray;
	//	RaycastHit hit;


	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			//		if (Input.GetMouseButton (0)) {
			GameObject bullet2 = (GameObject)Instantiate (bullet, playerCamera.transform.position, Quaternion.identity);

			Ray rayOrg = playerCamera.ScreenPointToRay (Input.mousePosition);

			Vector3 direction = rayOrg.direction;

			//bullet2を飛ばす
			bullet2.GetComponent<Rigidbody>().velocity = direction * speed;
		}
	}
}

			