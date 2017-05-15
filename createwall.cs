using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createwall : MonoBehaviour {

	public GameObject zhuankuai;

	// Use this for initialization
	void Start () {

		for (int i = 0; i <= 10; i++) {
			for (int j = 0; j <= 10; j++) {
				GameObject.Instantiate (zhuankuai, new Vector3 (i, j, 0), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
