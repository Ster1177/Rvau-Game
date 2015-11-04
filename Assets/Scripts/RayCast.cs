using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {
	public GameObject particle;
	void Update() {
		RaycastHit hit;
		if (Input.GetButtonDown("Fire1")) {
			Vector3 fwd = transform.TransformDirection(Vector3.forward);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit)) {
				Debug.Log("Disparou");
			    Debug.Log(hit);

				Instantiate(particle, hit.point, transform.rotation);
			}
		}
	}
}
