using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objeto3 : MonoBehaviour
{
	public ScriptComunicated ScriptComunicado;
	private Image Imagen;
	public bool girl1;
	RectTransform RectTrans;

	// Start is called before the first frame update
	void Start()
	{
		Imagen = GetComponent<Image>();
		RectTrans = GetComponent<RectTransform>();
	}

	// Update is called once per frame
	void Update()
	{
		if (ScriptComunicado.pasar == true && ScriptComunicado.pasar2 == false)
		{
			RectTrans.anchoredPosition = new Vector2(-7, -158);
			if (girl1 == false)
			{
				Imagen.enabled = false;
			}
			else
			{
				Imagen.enabled = true;
			}
		}



	}
}
