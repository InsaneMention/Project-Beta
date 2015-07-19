using UnityEngine;
using System.Collections;

public class BackGroundCamera : MonoBehaviour {
	
	Transform _backGroundCam;
	
	void Start () {
		_backGroundCam = GameObject.Find ("TheChosenOne").transform;
	}
	
	void Update () {
		transform.position = new Vector3 (_backGroundCam.position.x, _backGroundCam.position.y, -5);
	}
}