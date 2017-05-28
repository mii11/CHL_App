﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	public static Manager instance;

	public int curPlayerNum;
	public int curEnemyNum;
	int totalPlayerNum = 3;
	int totalEnemyNum = 50;
	int totalStagesNum = 1;

	public string[] Stages = {
		"stgStart",
		"stg1",
		"stgOver"
	};

	public GameObject gun;

	//	public int curStageNo = 0; //start画面なし 
	public int curStageNo = 1;
	//	public string curStageName = "";

	//	public int curPlayerNum = 3;
	//	public int curEnemyNum = 50;
	//	public int curStagesNum = 1;
	//	int curPlayerNum;
	//	int curEnemyNum;
	//	int curStagesNum;


	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
		}
		DontDestroyOnLoad (this);

		curPlayerNum = totalPlayerNum;
		curEnemyNum = totalEnemyNum;
	}

	// Update is called once per frame
	void Update () {

	}
}