using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {


	float rotetx = 0;
	float rotetz = 0;
	void Start () {
	
	}
	
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			transform.Rotate(1, 0, 0);
		}
		if(Input.GetKey(KeyCode.A)){
			transform.Rotate(0, 0, 1);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Rotate(-1, 0, 0);
		}
		if(Input.GetKey(KeyCode.D)){
			transform.Rotate(0, 0, -1);
		}
	}
}
