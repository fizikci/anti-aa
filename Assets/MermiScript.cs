using UnityEngine;
using System.Collections;

public class MermiScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public Vector3 axis;
	public float speed = 0.1f;

	// Update is called once per frame
	void Update () {
		transform.Translate (axis * speed);
	}

    void OnCollisionEnter(Collision otherObj)
    {
        Destroy(gameObject);
        if (otherObj.gameObject.tag == "Balon")
        {
            Destroy(otherObj.gameObject);

            var kalan = GameObject.FindGameObjectsWithTag("Balon").Length;
            Debug.Log("kalan: "+kalan);
            if (kalan == 1)
                TheGame.Instance.Success();
        }

        TheGame.Instance.AddMermi();

    }
}
