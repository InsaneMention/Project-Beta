using UnityEngine;
using System.Collections;

public class HeroCamera : MonoBehaviour {
	
	Transform _heroCam;
	
	void Start () {
		_heroCam = GameObject.Find ("TheChosenOne").transform;
	}
	
	void Update () {
		transform.position = new Vector3 (_heroCam.position.x, _heroCam.position.y+1.5f, -5);
	}
}