using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour {

	public GameObject[] backgroundsArray;
	public GameObject[] foregroundsArray;

	public float bgScrollSpeed = 0.0f;
	public float foregroundSpeed = 0.0f;
	// Use this for initialization
	void Start () {

		Transform bg2 = backgroundsArray [1].transform;
		bg2.position = new Vector3 (bg2.position.x,
		                                     bg2.position.y - bgScrollSpeed,
		                                     bg2.position.z);

		Transform fgBg2 = foregroundsArray [1].transform;
		fgBg2.position = new Vector3 (fgBg2.position.x,
		                             fgBg2.position.y - foregroundSpeed,
		                             fgBg2.position.z);
	}
	
	// Update is called once per frame
	void Update () {

		foreach (GameObject obj in backgroundsArray) {
				
			obj.transform.position = new Vector3(obj.transform.position.x,
			                                     obj.transform.position.y + bgScrollSpeed,
			                                     obj.transform.position.z);

			if(obj.transform.position.y > 10) {

				obj.transform.position = new Vector3(obj.transform.position.x,
				                                     -10f + bgScrollSpeed,
				                                     obj.transform.position.z);
			}
		}


		foreach (GameObject obj in foregroundsArray) {
			
			obj.transform.position = new Vector3(obj.transform.position.x,
			                                     obj.transform.position.y + foregroundSpeed,
			                                     obj.transform.position.z);
			
			if(obj.transform.position.y > 10) {
				
				obj.transform.position = new Vector3(obj.transform.position.x,
				                                     -10f + foregroundSpeed,
				                                     obj.transform.position.z);
			}
		}
	}
}
