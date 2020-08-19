using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour
{
	public ScriptComunicated Pasar2;
	public GameObject MainCanvas;
	
	void Start()
	{
		GameManager.nivel=0;
		MainCanvas = GameObject.FindGameObjectWithTag("MainCanvas");
		Pasar2 = MainCanvas.GetComponent<ScriptComunicated>();
	}
	public void Escena3()
    {
		SceneManager.LoadScene(2);
		Pasar2.pasar2 = true;
    }
	public void Escena4()
	{
		SceneManager.LoadScene(7);
	}
	public void Escena5()
	{
		SceneManager.LoadScene(4);
		Pasar2.pasar = true;
	}
	public void Escena6()
	{
		SceneManager.LoadScene(5);
		Pasar2.pasar = true;
	}
	public void Escena7()
	{
		SceneManager.LoadScene(9);
	}
}
