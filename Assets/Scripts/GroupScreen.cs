﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroupScreen : MonoBehaviour {
	public Text title;
	public Text description;

	// Use this for initialization
	void Start () {
		Group group = GroupData.GetItem(LevelManager.groupAttribute);
		//if(group == null){
			title.text = "Test";
			description.text = "Testing";
		//}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
