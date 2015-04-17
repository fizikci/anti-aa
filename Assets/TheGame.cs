using UnityEngine;
using System.Collections;

public class TheGame : MonoBehaviour {

	public int level = 1;
	public Transform preBalon;
	public Transform preMermi;


	// Use this for initialization
	void Start () {
		for (int i=0; i<level; i++) {
			Transform a = (Transform)Instantiate(preBalon, new Vector3(0, 0, 0), Quaternion.identity);
			a.RotateAround(new Vector3(0,0,1), 360/level*i);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Transform a = (Transform)Instantiate(preMermi);
		}
	}
}
