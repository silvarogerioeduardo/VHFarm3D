using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	public Camera[] Cameras;
	public GameObject[] Agents;

	public int camIndex = 0;
	public int agtIndex = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if(camIndex > 0) {
				camIndex = (camIndex + 1) % Cameras.Length;
			}

			if(camIndex == 0)
			{
				if(agtIndex < Agents.Length-1)
				{
					agtIndex++;
					Cameras[camIndex].GetComponent<ThirdPersonCamera>().lookAt = Agents[agtIndex].transform;
				}
				else {
					agtIndex = -1;
					camIndex++;
				}
			}
			
			for(int cam = 0; cam < Cameras.Length; cam++)
			{
				Cameras[cam].gameObject.SetActive(cam == camIndex);
			}
		}
	}
}
