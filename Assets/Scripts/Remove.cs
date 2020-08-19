using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Remove : MonoBehaviour
{
	public GameObject[] PlayerMain;
	// Start is called before the first frame update
	void Start()
	{
		PlayerMain = GameObject.FindGameObjectsWithTag("Player");


	}

	void Update()
	{
		foreach (GameObject Objects in PlayerMain)
		{
			Objects.GetComponent<Image>().enabled = false;
		}
	}

}
