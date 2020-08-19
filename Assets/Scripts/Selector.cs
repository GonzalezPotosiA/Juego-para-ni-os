using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Selector : MonoBehaviour
{
	public ScriptComunicated ScriptCanvas;
	public Objeto1 Chico1;
	public Objeto2 Chico2;
	public Objeto3 Chica1;
	public Objeto4 Chica2;
	public bool selecter = false;
	private Text Texto;
	public bool Boy1, Boy2, Girl1, Girl2;

	public void Seleccionado()
	{
		selecter = true;
	}

	void Start()
	{
		Texto = GetComponent<Text>();

	}

	public void NoActivar()
	{
		if (selecter == false)
		{
			Texto.enabled = true;
		}	
	}

	public void Niño1()
	{
		if (Boy1 == false)
		{
			Boy1 = true;
			Boy2 = false;
			Girl1 = false;
			Girl2 = false;
		}
		
	}

	public void Niño2()
	{
		if (Boy2 == false)
		{
			Boy1 = false;
			Boy2 = true;
			Girl1 = false;
			Girl2 = false;
			
		}
	

	
	}

	public void Niña1()
	{
		if (Girl1 == false)
		{
			Boy1 = false;
			Boy2 = false;
			Girl1 = true;
			Girl2 = false;
		}
		
	}

	public void Niña2()
	{
		if (Girl2 == false)
		{
			Boy1 = false;
			Boy2 = false;
			Girl1 = false;
			Girl2 = true;
		}
	
	}

	public void CambioDeEscena()
	{
		if (selecter == true)
		{
			SceneManager.LoadScene(1);
			ScriptCanvas.pasar = true;
		}
	}


	void Activar()
	{
		Texto.enabled = false;
	}



	void Update()
	{
		if (selecter == true)
		{
			Activar();
		}
	}

	

}
