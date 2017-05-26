using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
	public float bulletSpeed;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 5);
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (transform.forward * Time.deltaTime * bulletSpeed);
	}
}
