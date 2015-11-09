using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class hit : MonoBehaviour {

	//public GameObject bearBody;
	public float thrust = 5;
	public  float dieTime = 1.2f;
	public int score = 0;
	private Text txt;

	void OnTriggerEnter(Collider other) {
	//	Debug.Log ("ACERTOU URSO");
		GameObject scoreBoard = GameObject.FindWithTag("Score");
	
		
			//Destroy (other.gameObject);
			//if(other.gameObject.transform.Rotate.z >= 0) 
				//other.gameObject.transform.Rotate(0,0,30);
	//	Debug.Log ("Matei: " + other.gameObject.name);
	//	Debug.Log ("Eu sou um: " + gameObject.name);
		if (other.gameObject.name == "Bullet") {
		//	Debug.Log("Morre Diabo");
			score+= 5;
			txt = scoreBoard.GetComponent<Text>();
			txt.text = score.ToString();

			transform.GetComponentInChildren<Animator>().SetTrigger ("die");
			Destroy(gameObject,dieTime);
		}
			/*bearBody = other.gameObject.GetComponent<Rigidbody>();
			 
			bearBody.AddForce(this.GetComponent<Rigidbody>().velocity.normalized*thrust, ForceMode.Impulse);*/
			//other.gameObject.transform.position -= transform.forward * Time.deltaTime * 5;


}
}