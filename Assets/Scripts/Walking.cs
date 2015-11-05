using UnityEngine;
using System.Collections;

public class Walking : MonoBehaviour {
	private NavMeshAgent agent;
	public GameObject target;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		agent.SetDestination (target.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
