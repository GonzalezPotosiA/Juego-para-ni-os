using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VoiceRecognition : MonoBehaviour
{
	public TextMeshProUGUI myTMP;

	private KeywordRecognizer reconocePalabras;
	private ConfidenceLevel confidencialidad = ConfidenceLevel.Low;
	private Dictionary<string, Accion> palabrasAccion = new Dictionary<string, Accion>();
	public PasarEmociones PasEmociones;
	public PasarEmocionesPer PasEmocionesPer;
	public PasarVideos PasVideos;
	public string Palabra;
	public Text Inicio;

	//crear Delegado para la acción a ejecutar
	private delegate void Accion();

	void Start()
	{
		
		if(GameManager.nivel==1)
		{
			PasEmociones = FindObjectOfType<PasarEmociones>();
		}
		else if(GameManager.nivel==2)
		{
			PasEmocionesPer = FindObjectOfType<PasarEmocionesPer>();
		}
		else{
			PasVideos = FindObjectOfType<PasarVideos>();
		}
		
		
	}
	// Start is called before the first frame update
	public void Talk()
	{
		if(GameManager.nivel==1)
		{
			Inicio.text = "";
			palabrasAccion.Add("Feliz", PasEmociones.FelizFunc);
			palabrasAccion.Add("Triste", PasEmociones.TristeFunc);
			palabrasAccion.Add("Enojado", PasEmociones.EnojadoFunc);
			palabrasAccion.Add("Asustado", PasEmociones.AsustadoFunc);
			palabrasAccion.Add("Pensativo", PasEmociones.PensativoFunc);
		
		}
		else if(GameManager.nivel==2)
		{
			Inicio.text = "";
			palabrasAccion.Add("Feliz", PasEmocionesPer.FelizFunc);
			palabrasAccion.Add("Enojado", PasEmocionesPer.EnojadoFunc);
			palabrasAccion.Add("Confundido", PasEmocionesPer.ConfundidoFunc);
			palabrasAccion.Add("Asustado", PasEmocionesPer.AsustadoFunc);
		}	
		else if(GameManager.nivel==3)
		{
			Inicio.text = "";
			palabrasAccion.Add("Sara", PasVideos.Historieta1);
			palabrasAccion.Add("Andres", PasVideos.Historieta2);
			palabrasAccion.Add("Amigo de Carlos", PasVideos.Historieta3);
			palabrasAccion.Add("Catalina", PasVideos.Historieta4);
			palabrasAccion.Add("Maria", PasVideos.Historieta5);
		
		}

		reconocePalabras = new KeywordRecognizer(palabrasAccion.Keys.ToArray(), confidencialidad);
		reconocePalabras.OnPhraseRecognized += OnKeywordsRecognized;
		reconocePalabras.Start();
	}


	private void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
	{
		myTMP.text = args.text;
		palabrasAccion[args.text].Invoke();
		Palabra = args.text;
	}

	void Hablar()
	{
		//Debug.Log("Dijo hola");
	}

	public void Atras()
	{
		SceneManager.LoadScene(1);
	}
}