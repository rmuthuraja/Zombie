using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour {

	public GameObject[] backgroundsArray;

	public float scrollSpeed = 0.0f;

	// Use this for initialization
	void Start () {

		GameObject bg1 = backgroundsArray [0];
		GameObject bg2 = backgroundsArray [1];

		bg1.transform.position = new Vector3 (0, 0, 0);
		bg2.transform.position = new Vector3 (0, -10.24f, 0);

	}
	
	// Update is called once per frame
	void Update () {

		foreach (GameObject obj in backgroundsArray) {
				
			obj.transform.position = new Vector3(obj.transform.position.x,
			                                     obj.transform.position.y + scrollSpeed,
			                                     obj.transform.position.z);

			if(obj.transform.position.y > 10.24) {

				obj.transform.position = new Vector3(obj.transform.position.x,
				                                     -10.24f + scrollSpeed,
				                                     obj.transform.position.z);
			}
		}
	}
}
