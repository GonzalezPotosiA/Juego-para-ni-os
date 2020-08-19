using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableEscene : MonoBehaviour
{
	public GameObject[] Games1;
	public GameObject[] Games2;

	public GameObject[] Games1Escena2;
	public GameObject[] Games2Escena2;

	public ScriptComunicated ScriptComunicado;


	void Update()
	{
		if (ScriptComunicado.pasar == true)
		{
			Games1 = GameObject.FindGameObjectsWithTag("Disable");

			foreach (GameObject Objects in Games1)
			{
				Objects.GetComponent<Text>().enabled = false;
			}

			Games2 = GameObject.FindGameObjectsWithTag("DisableIm");

			foreach (GameObject Objects in Games2)
			{
				Objects.GetComponent<Image>().enabled = false;
			}


			Games1Escena2 = GameObject.FindGameObjectsWithTag("Esc");

			foreach (GameObject Objects in Games1Escena2)
			{
				Objects.GetComponent<Text>().enabled = true;
			}

			Games2Escena2 = GameObject.FindGameObjectsWithTag("EscIm");

			foreach (GameObject Objects in Games2Escena2)
			{
				Objects.GetComponent<Image>().enabled = true;
			}
		} 

		else
		{
			Games1 = GameObject.FindGameObjectsWithTag("Disable");

			foreach (GameObject Objects in Games1)
			{
				Objects.GetComponent<Text>().enabled = true;
			}

			Games2 = GameObject.FindGameObjectsWithTag("DisableIm");

			foreach (GameObject Objects in Games2)
			{
				Objects.GetComponent<Image>().enabled = true;
			}


			Games1Escena2 = GameObject.FindGameObjectsWithTag("Esc");

			foreach (GameObject Objects in Games1Escena2)
			{
				Objects.GetComponent<Text>().enabled = false;
			}

			Games2Escena2 = GameObject.FindGameObjectsWithTag("EscIm");

			foreach (GameObject Objects in Games2Escena2)
			{
				Objects.GetComponent<Image>().enabled = false;
			}
		}

	}
}
