using UnityEngine;
using System.Collections;

public class GunMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.mousePosition.y > transform.position.y)
			//transform.rotation = (new Vector3(transform.rotation.x,transform.rotation.y, (Input.mousePosition.x) / (Mathf.Pow (Input.mousePosition.x,2) + Mathf.Pow (Input.mousePosition.y, 2))));
			transform.rotation = Quaternion.FromToRotation(new Vector3(1,0),new Vector3(PlayerEngine._leftSide*(Input.mousePosition.x - Screen.width/2),Input.mousePosition.y));
	}
}
