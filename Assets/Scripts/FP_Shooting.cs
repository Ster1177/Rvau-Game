using UnityEngine;
using System.Collections;

public class FP_Shooting : MonoBehaviour {
	
	public GameObject bullet_prefab;
	public float bulletImpulse = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetButtonDown("Fire1") ) {
			Camera cam = Camera.main;
			GameObject thebullet = (GameObject)Instantiate(bullet_prefab, cam.transform.position + cam.transform.forward, cam.transform.rotation * Quaternion.Euler(90,0,0));
			thebullet.GetComponentsInChildren<Rigidbody>()[0].AddForce( cam.transform.forward * bulletImpulse, ForceMode.Impulse);
			thebullet.GetComponentsInChildren<Rigidbody>()[2].AddForce( cam.transform.right * 0.3f, ForceMode.Impulse);
		}
	}
}
