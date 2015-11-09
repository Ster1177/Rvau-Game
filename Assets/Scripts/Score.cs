using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int score = 0;
	public GameObject scoreBoard;
	private Text txt;
	public static Score Instance;

	void Awake(){
		Instance = this;
	}
	
	// Use this for initialization
	void Start () {
		txt = scoreBoard.GetComponent<Text>();
		txt.text = score.ToString();
	}
	
	void Update (){
		txt = scoreBoard.GetComponent<Text>();
		txt.text = score.ToString();
	}
}
