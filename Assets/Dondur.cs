using UnityEngine;
using System.Collections;

public class Dondur : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public Vector3 axis;
	public float speed = 0.1f;
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (axis, Time.deltaTime*speed);
	}
}
