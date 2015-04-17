using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TheGame : MonoBehaviour {

	public int level = 1;

    public Camera camera;
    public Transform preBalon;
    public Transform preMermi;
    public Text levelNo;
    public int mermiCount;

    public static TheGame Instance;
    public MermiScript currMermi = null;


	// Use this for initialization
	void Start () {
        Instance = this;

		for (int i=0; i<level; i++) {
			Transform a = (Transform)Instantiate(preBalon);
            a.Rotate(new Vector3(0, 0, 360 / level * i));
            //a.rotation.eulerAngles = new Vector3(0, 0, 360 / level * i);//RotateAround(new Vector3(0,0,1), 360/level*(level-i));
		}
        levelNo.text = level.ToString();
        mermiCount = Mathf.CeilToInt(level * 1.3f);

        Transform m = (Transform)Instantiate(preMermi);
        currMermi = m.GetComponent<MermiScript>();
        currMermi.speed = 0f;
        m.FindChild("ballNo").GetComponent<TextMesh>().text = mermiCount.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
            if (mermiCount == 0)
                return;

            currMermi.speed = .1f;
            mermiCount--;
		}
	}

    public void AddMermi()
    {
        if (mermiCount > 0)
        {
            Transform m = (Transform)Instantiate(preMermi);
            currMermi = m.GetComponent<MermiScript>();
            currMermi.speed = 0f;
            m.FindChild("ballNo").GetComponent<TextMesh>().text = mermiCount.ToString();
        }
        else
        {
            levelNo.text = "END";
        }
    }

    internal void Success()
    {
        camera.backgroundColor = Color.green;
    }
}
