using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesControler : MonoBehaviour {
   public float speed = 3f;
   public GameObject[] prefabs = new GameObject [2];
    public List<GameObject> [] Obstacles = new List<GameObject> [2];
    public Transform bird;

	// Use this for initialization
	void Start () {
        Obstacles[0] = new List<GameObject>();
        Obstacles[1] = new List<GameObject>();



    }

	
	// Update is called once per frame
	void Update () {
		 
		int sw = Screen.width;
		int sh = Screen.height;
		int count = Obstacles [0].Count;
		bool isAdd = false;
		int	h = 350;
		int	n = 300;
		if ((Bird.Instance.score) >= 15) {
				h = 250;
				n = 300;
		} 
		if ((Bird.Instance.score) >= 30) {
			 h = 200;
			n = 300;
		}
		if ((Bird.Instance.score) >= 60) {
			h = 150;
			n = 300;
		}
		if ((Bird.Instance.score) >= 100) {
				h = 100;
			    n = 300;
			}


		if (count > 0) {
			List<GameObject> top = Obstacles [0];
			List<GameObject> bottom = Obstacles [1];

			for (int i = 0; i < count; i++) {
				top [i].transform.Translate (Vector3.right * -speed * Time.deltaTime);
				bottom [i].transform.Translate (Vector3.right * -speed * Time.deltaTime);
				Vector3 pos = Camera.main.WorldToScreenPoint (top [i].transform.position);
				if (pos.x < 0) {
					Destroy (top [i]);
					Destroy (bottom [i]);
					top.RemoveAt (i);
					bottom.RemoveAt (i);
					if (--count <= 0) {
						isAdd = true;
						break;
					}
				} 
			} 
			if (!isAdd) {
				Vector3 p = Camera.main.WorldToScreenPoint (top [count - 1].transform.position);
				if (p.x < sw) {
					isAdd = true;
				}
			}
		} else
			isAdd = true;
		
		if (isAdd) {
			float between = Random.Range (h, n);
			Vector3 pos = new Vector3 (sw + Random.Range (0, 200), sh / 2 + Random.Range (-50, 50), 1);
			pos.y += between / 2;
			GameObject obstatcle = Instantiate<GameObject> (prefabs [0]);
			obstatcle.transform.position = Camera.main.ScreenToWorldPoint (pos) + Vector3.forward * bird.position.z + Vector3.right * 3.6f;
			Obstacles [0].Add (obstatcle);

			obstatcle = Instantiate<GameObject> (prefabs [1]);
			pos.y -= between;
			obstatcle.transform.position = Camera.main.ScreenToWorldPoint (pos) + Vector3.forward * bird.position.z + Vector3.right * 3.6f;
			Obstacles [1].Add (obstatcle);
		}


	
	}
}
