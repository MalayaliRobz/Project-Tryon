using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swap : MonoBehaviour {

	public GameObject[] Models;
	private int i = 0;
	// Use this for initialization
	void Start () {
		print ("started");
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Next()
	{
		if (Models[i].activeInHierarchy == true && i < 3) 
		{
			Models[i].SetActive (false);
			Models[i + 1].SetActive (true);
			i++;
			print ("Next pressed");
		}
		print ("pressed once");
	}

	public void Prev()
	{
		if (Models [i].activeInHierarchy == true && i > 0) 
		{
			Models [i].SetActive (false);
			Models [i - 1].SetActive (true);
			i--;
		}
	}
}
