using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScriptComunicated : MonoBehaviour
{
	public Selector selector;
	public bool pasar = false;
	public bool pasar2 = false;
	public int seleccionado = 0;
	public Objeto1 Chico1;
	public Objeto2 Chico2;
	public Objeto3 Chica1;
	public Objeto4 Chica2;


	private void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
	}

	void Update()
	{

		if (pasar == true)
		{
			Chico1.boy1 = false;
			Chico2.boy2 = false;
			Chica1.girl1 = false;
			Chica2.girl2 = false;


			if (selector.Boy1 == true)
			{
				Chico1.boy1 = true;
				seleccionado = 1;
			}

			if (selector.Boy2 == true)
			{
				Chico2.boy2 = true;
				seleccionado = 2;
			}

			if (selector.Girl1 == true)
			{
				Chica1.girl1 = true;
				seleccionado = 3;
			}

			if (selector.Girl2 == true)
			{
				Chica2.girl2 = true;
				seleccionado = 4;
			}

			if (pasar2 == true)
			{

			}

		}

	}
}



