using UnityEngine;
using System.Collections;

public class TargetSensor : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider agent) 
	{
		if (agent.CompareTag ("AGENT") && agent.GetComponent<AgentDeliberation>().getTargetName() == gameObject.name) 
		{
			agent.GetComponent<AgentDeliberation>().SelectTarget();
		}
	}
}
