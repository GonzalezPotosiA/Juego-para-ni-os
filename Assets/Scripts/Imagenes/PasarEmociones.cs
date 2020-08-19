using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PasarEmociones : MonoBehaviour
{
	public Image Feliz, Triste, Enojado, Asustado, Pensativo;
	public Text Puntuacion, AnswerType;
	public int conteo = 1, nivel =1;

	void Awake()
	{
		GameManager.nivel=1;
	}
    public void FelizFunc()
    {

        if (conteo == 1)
		{
			Feliz.GetComponent<Image>().enabled = false;
			Triste.GetComponent<Image>().enabled = true;
			conteo = 2;
			Puntuacion.text = "1/5";
			AnswerType.text = "Correcto!";
		}

		else
		{
			AnswerType.text = "Incorrecto, inténtalo de nuevo";
		}
    }

	public void TristeFunc()
	{
		if (conteo == 2)
		{
			Triste.GetComponent<Image>().enabled = false;
			Enojado.GetComponent<Image>().enabled = true;
			Puntuacion.text = "2/5";
			AnswerType.text = "Correcto!";
			conteo = 3;
		}

		else
		{
			AnswerType.text = "Incorrecto, inténtalo de nuevo";
		}
	}

	public void EnojadoFunc()
	{
		if (conteo == 3)
		{
			Enojado.GetComponent<Image>().enabled = false;
			Asustado.GetComponent<Image>().enabled = true;
			Puntuacion.text = "3/5";
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
			Asustado.GetComponent<Image>().enabled = false;
			Pensativo.GetComponent<Image>().enabled = true;
			Puntuacion.text = "4/5";
			AnswerType.text = "Correcto!";
			conteo = 5;
		}

		else
		{
			AnswerType.text = "Incorrecto, inténtalo de nuevo";
		}
	}

	public void PensativoFunc()
	{
		if (conteo == 5)
		{

			Puntuacion.text = "5/5";
			AnswerType.text = "Correcto!";
			GameManager.nivel=0;
			SceneManager.LoadScene(3);
			
		}

		else
		{
			AnswerType.text = "Incorrecto, inténtalo de nuevo";
		}
	}
}
