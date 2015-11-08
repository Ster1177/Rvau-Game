using UnityEngine;
using System.Collections;

public class hit : MonoBehaviour {

	//public GameObject bearBody;
	public float thrust = 5;
	public  float dieTime = 1.2f;

	void OnTriggerEnter(Collider other) {
	//	Debug.Log ("ACERTOU URSO");
	
		
			//Destroy (other.gameObject);
			//if(other.gameObject.transform.Rotate.z >= 0) 
				//other.gameObject.transform.Rotate(0,0,30);
	//	Debug.Log ("Matei: " + other.gameObject.name);
	//	Debug.Log ("Eu sou um: " + gameObject.name);
		if (other.gameObject.name == "Bullet") {
		//	Debug.Log("Morre Diabo");
			transform.GetComponentInChildren<Animator>().SetTrigger ("die");
			Destroy(gameObject,dieTime);
		}
			/*bearBody = other.gameObject.GetComponent<Rigidbody>();
			 
			bearBody.AddForce(this.GetComponent<Rigidbody>().velocity.normalized*thrust, ForceMode.Impulse);*/
			//other.gameObject.transform.position -= transform.forward * Time.deltaTime * 5;


}
}