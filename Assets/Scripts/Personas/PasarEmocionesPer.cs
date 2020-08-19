using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PasarEmocionesPer : MonoBehaviour
{
	//public Image Feliz, Triste, Enojado, Asustado, Pensativo;
	public Image Feliz, Enojado, Confundido, Asustado, Triste;
	public Text Puntuacion, AnswerType;
	public int conteo = 1, nivel =2;

	void Start()
	{
		GameManager.nivel=2;
	}


    public void FelizFunc()
    {

        if (conteo == 1)
		{
			Feliz.GetComponent<Image>().enabled = false;
			Enojado.GetComponent<Image>().enabled = true;
			conteo = 2;
			Puntuacion.text = "1/4";
			AnswerType.text = "Correcto!";
		}

		else
		{
			AnswerType.text = "Incorrecto, inténtalo de nuevo";
		}
    }

	public void EnojadoFunc()
	{
		if (conteo == 2)
		{
			Enojado.GetComponent<Image>().enabled = false;
			Confundido.GetComponent<Image>().enabled = true;
			Puntuacion.text = "2/4";
			AnswerType.text = "Correcto!";
			conteo = 3;
		}

		else
		{
			AnswerType.text = "Incorrecto, inténtalo de nuevo";
		}
	}

	public void ConfundidoFunc()
	{
		if (conteo == 3)
		{
			Confundido.GetComponent<Image>().enabled = false;
			Asustado.GetComponent<Image>().enabled = true;
			Puntuacion.text = "3/4";
			AnswerType.text = "Correcto!";
			conteo = 4;
		}

		else
		{
			AnswerType.text = "Incorrecto, inténtalo de nuevo";
		}
	}

	
	public void AsustadoFunc()
	{
		if (conteo == 4)
		{
			Puntuacion.text = "4/4";
			AnswerType.text = "Correcto!";
			GameManager.nivel=0;
			SceneManager.LoadScene(6);
			
		}

		else
		{
			AnswerType.text = "Incorrecto, inténtalo de nuevo";
		}
	}

	public void Atras()
	{
		SceneManager.LoadScene(1);
	}
}
