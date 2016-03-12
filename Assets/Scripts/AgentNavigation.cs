using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AgentNavigation : MonoBehaviour 
{
	public Text Target_UI;
	private Transform Target = null;

	// Use this for initialization
	void Update () 
	{
		if(Target)
			GetComponent<NavMeshAgent> ().destination = Target.localPosition;	
	}
	
	// Update is called once per frame
	public void GoTo (string strTargetName) 
	{
		Target = GameObject.Find (strTargetName).transform;
		Target_UI.text = strTargetName;
		//Debug.Log (gameObject.name + " is going to... " + strTargetName);
	}
}
