using UnityEngine;
using System.Collections;

public class AgentDeliberation : MonoBehaviour 
{
	//public string[] Targets;
	public GameObject[] Targets;
	private string strTargetName = "";

	// Use this for initialization
	void Start () 
	{
		Targets = GameObject.FindGameObjectsWithTag ("WAYPOINT");
		SelectTarget ();
	}
	
	// Update is called once per frame
	public void SelectTarget () 
	{
		if (Targets.Length == 0)
			return;

		int iChoice;
		do 
		{
			iChoice = Random.Range (0, Targets.Length);
		} 
		while(Targets[iChoice].name == strTargetName);

		strTargetName = Targets[iChoice].name;
		GetComponent<AgentNavigation> ().GoTo (strTargetName);
	}

	public string getTargetName()
	{
		return strTargetName;
	}
}
