using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createwall : MonoBehaviour {

	public GameObject zhuankuai;

	// Use this for initialization
	void Start () {

//		for (int i = 0; i <= 10; i++) {
//			for (int j = 0; j <= 10; j++) {
//				GameObject.Instantiate (zhuankuai, new Vector3 (i, j, 0), Quaternion.identity);
//			}
//		}
		int numx=0,numy=0;
		while (numx < 10) {
			numy = 0;
			while (numy < 10) {
				GameObject.Instantiate (zhuankuai, new Vector3 (numx, numy, 0), Quaternion.identity);
				numy++;
			}
			numx++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
