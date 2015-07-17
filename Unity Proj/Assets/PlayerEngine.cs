using UnityEngine;
using System.Collections;

public class PlayerEngine : MonoBehaviour {

	public const float speed = 1F;
	public GameObject Hero;
	public Camera HeroCamera;
	public float buff = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		buff = Hero.transform.position.x;
		HeroCamera.transform.position.x = buff;
		buff = Hero.transform.position.y;
		HeroCamera.transform.position.y = buff;
	}
}
