using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float smooth = 2.0F;
	public float tiltAngle = 30.0F;

	// Update is called once per frame
	void Update () {
	//	if ( Input.GetKey(KeyCode.UpArrow) )
			//move up
	//		if ( Input.GetKey(KeyCode.DownArrow) )
				//move down
		if ( Input.GetKey(KeyCode.RightArrow) )
		{
			print("right");
			float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
			float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
			Quaternion target = Quaternion.Euler(tiltAroundX, 180, tiltAroundZ);
			transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
			transform.animation.Play("rightTurn");
		}
			
		else if ( Input.GetKey(KeyCode.LeftArrow) )
		{
			print("left");
			float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
			float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
			Quaternion target = Quaternion.Euler(tiltAroundX, 180, tiltAroundZ);
			transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
			transform.animation.Play("leftAnim");
		}
		else
		{
		transform.animation.Play("fallAnim");
			Quaternion target = Quaternion.Euler(0, 180, 0);
			transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
		}
	}
}



