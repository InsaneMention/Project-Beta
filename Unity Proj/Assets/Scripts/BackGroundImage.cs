using UnityEngine;
using System.Collections;

public class BackGroundImage : MonoBehaviour {
	public GameObject _backGroundImage;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 7; i++) {
			Instantiate (_backGroundImage, new Vector3 (i*2 - 6, -4.5f, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
