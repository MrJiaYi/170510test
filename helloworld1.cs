using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloworld1 : MonoBehaviour {

	public int num1 = 100;
	public int num2 = 99;

	// Use this for initialization
	void Start () {
		//print("hello world");
//		int score = 0;
//		float score2 = 23.0f;
//		bool shifoubiye = true;
//
//		print (score);
//		print (score2);
//		print (shifoubiye);

//		int num1 = 34;
//		int num2 = 43;
//
//		int result1 = num1 + num2;
//		int result2 = num1 - num2;
//		int result3 = num1 * num2;
//		int result4 = num1 / num2;
//
//		print (result1);
//		print (result2);
//		print (result3);
//		print (result4);

//		int i = 100;
//
//		string wenzi1 = "I am a chinese";
//		string wenzi2 = "I am a coder";
//
//		string resStr = wenzi1 + "," + wenzi2;
//		string resStr2 = wenzi1 + wenzi2 + i;
//
//		print (wenzi1);
//		print (wenzi2);
//		print (resStr);
//		print (resStr2);

//		int num1 = 100;
//		int num2 = 99;

//		bool res = num1 <= num2;
//		bool res2 = num1 < num2;
//		bool res3 = num1 == num2;
//		bool res4 = num1 > num2;
//		bool res5 = num1 >= num2;
//
//		print (res);
//		print (res2);
//		print (res3);
//		print (res4);
//		print (res5);

//		int i = 0;
//		for (; i < 100; i++) {
//			print (i);
//		}

		int i = 1;
		while (i<99) {
			if((i%2)!=0){
				i++;
				print (i);
				//continue;
			}

			i++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
