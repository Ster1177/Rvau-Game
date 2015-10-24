using UnityEngine;
using System.Collections;

public class hit : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Enemy")) {
			Debug.Log ("ACERTOU URSO");
			Destroy (other.gameObject);
		} else if(!other.CompareTag("Ignore"))
			Destroy (this.gameObject);
	}
}
