using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {

	//private Camera cam;
	private float currentX = 0.0f;
	private float currentY = 0.0f;
	private float sensivityX = 4.0f;
	private float sensivityY = 2.0f;
	private Transform camTransform;

	public Transform lookAt;
	public float camDistance = 4.0f;
	public float camHeight = 3.0f;

	// Use this for initialization
	void Start () {
		camTransform = transform;
		//cam = Camera.main;
	}

	void Update() {
		currentX += Input.GetAxis ("Mouse X") * sensivityX;
		currentY += Input.GetAxis ("Mouse Y") * sensivityY;
		//Debug.Log (currentY);
		currentY = Mathf.Clamp (currentY, 0.0f, 50.0f);
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 dir = new Vector3 (-camDistance, camHeight, 0.0f);
		Quaternion rotation = Quaternion.Euler (0.0f, currentX, currentY);
		camTransform.position = lookAt.position + rotation * dir;
		camTransform.LookAt (lookAt.position);
	}
}
