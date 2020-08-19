using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objeto1 : MonoBehaviour
{
	public ScriptComunicated ScriptComunicado;
	private Image Imagen;
	RectTransform RectTrans;
	public bool boy1;

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

			if (boy1 == false)
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
