using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
	public ScriptComunicated Escena;
	public Selector select;
	public Image ImagenBack;

	// Start is called before the first frame update
	void Start()
	{
		ImagenBack = GetComponent<Image>();
	}

	void Update()
	{
		if (Escena.pasar == true)
		{
			ImagenBack.enabled = true;
		}
		else
		{

			ImagenBack.enabled = false;

		}

	}
	public void Back()
    {
		
        if (Escena.pasar == true && Escena.pasar2 == false)
		{
			SceneManager.LoadScene(0);
			select.selecter = false;
			select.Boy1 = false;
			select.Boy2 = false;
			select.Girl1 = false;
			select.Girl2 = false;
		}

		if (Escena.pasar2 == true)
		{
			SceneManager.LoadScene(1);
		}

    }
}
