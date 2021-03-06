﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Permissions;

public class EventData{

	private static Dictionary<string, Event> _table = new Dictionary<string, Event>(); //Key  is Year and Month ie 201701: January of 2017

	public static void LoadItemsData(){
		Event newGroup = new Event()
		{
			nameID = "ExtraFood",
			guiName = "Extra Food",
			description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam maximus erat sed elit tristique hendrerit. Fusce dictum tortor neque, id vulputate erat tristique at. Aliquam vestibulum tincidunt odio a ultrices. Nullam id iaculis nisl. Ut placerat pharetra vestibulum. Vestibulum quis pharetra magna. Vivamus dapibus mauris quis nisi eleifend hendrerit ac at nulla. Sed et magna eget mauris vehicula finibus. Donec nec venenatis erat.",
			turn = 0,
			foodMultiplier = 1
			
			
		};

		_table.Add(newGroup.nameID, newGroup);

		newGroup = new Event()
		{
			//This Event is set in GameManager
			nameID = "Starvation",
			guiName = "Starvation",
			description = "Population has starved.",
			turn = 0,
			happinessEffect = 0,
			happinessMultiplier = 0,
			foodEffect = 0,
			foodMultiplier = 0,
			populationEffect = 0,
			populationMultiplier = 0
			
		};

		_table.Add(newGroup.nameID, newGroup);
		
		newGroup = new Event()
		{	
			//This Event is set in GameManager
			nameID = "Consume",
			guiName = "Consume Food",
			description = "Population has starved.",
			turn = 0,
			happinessEffect = 0,
			happinessMultiplier = 0,
			foodEffect = 0,
			foodMultiplier = 0,
			populationEffect = 0,
			populationMultiplier = 0
			
		};

		_table.Add(newGroup.nameID, newGroup);
		
	}

	public static Event GetItem(string name){
		if (_table.Count == 0){
			LoadItemsData();
		}
		Event temp = null;
		if(_table.TryGetValue(name, out temp)){
			return temp;
		}else{
			return null;
		}

	}
}

[System.Serializable]
public class Event 
{

	public enum EventType{Agriculture,Urban,Recreational,Ecology};
	public string nameID;
	public string guiName;
	public string description;
	public int turn;
	public float happinessEffect;
	public float happinessMultiplier;
	public float foodEffect;
	public float foodMultiplier;
	public float populationEffect;
	public float populationMultiplier;

	public void InstantEffect()
	{
		GameManager.Happiness += happinessEffect;
		GameManager.HappinessMultiplier += happinessMultiplier;
		GameManager.Food += foodEffect;
		GameManager.FoodMultiplier += foodMultiplier;
		GameManager.PopulationEffect += populationEffect;
		GameManager.PopulationMultiplier += populationMultiplier;
	}

	public Event Clone()
	{
		Event newGroup = new Event()
		{
			nameID = this.nameID,
			guiName = this.guiName,
			description = this.description,
			turn = this.turn,
			happinessEffect = this.happinessEffect,
			happinessMultiplier = this.happinessMultiplier,
			foodEffect = this.foodEffect,
			foodMultiplier = this.foodMultiplier,
			populationEffect = this.populationEffect,
			populationMultiplier = this.populationMultiplier
			
		};
		return newGroup;
	}

}
