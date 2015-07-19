using UnityEngine;
using System.Collections;

public class PlayerEngine : MonoBehaviour {
	
	public const float speed = 0.1F;
	public static int _leftSide = -1;

	void Start () {

	}
	
	void Update () {
		switch (_leftSide) {
		case -1:
			transform.localScale = new Vector2(-0.2f,transform.localScale.y);
			break;
		case 1:
			transform.localScale = new Vector2(0.2f,transform.localScale.y);
			break;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			_leftSide = -1;
			transform.position = new Vector2 (transform.position.x - speed, transform.position.y);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			_leftSide = 1;
			transform.position = new Vector2 (transform.position.x + speed, transform.position.y);
		}
	}
}


