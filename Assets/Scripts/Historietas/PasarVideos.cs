
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PasarVideos : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public VideoClip historieta1, historieta2, historieta3, historieta4, historieta5;
    public Text Puntuacion, AnswerType; 
    public Text textBot1, textBot2, textBot3, textBot4, textBot5;   
    public int conteo =1, nivel=3;
    public Button sub1, sub2, sub3, sub4, sub5;


    

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    void Start()
    {
        FunInicialBotones();
        GameManager.nivel=3;
        videoPlayer.clip= historieta1;
        videoPlayer.Play();
        
    }

   //Funciones para el cambio de historieta

    public void Historieta1(){
       
        
        if(conteo==1)
        {
            FunBotonesSub1();
            videoPlayer.Stop();
            videoPlayer.clip= historieta2;
            videoPlayer.Play();
            conteo=2;
            Puntuacion.text = "1/5";
            AnswerType.text="Correcto!";
            StartCoroutine("Esperar");
        }
        else
        {

            AnswerType.text ="Incorrecto, inténtalo de nuevo:" ;
        
        }
        
    }
    public void Historieta2()
    {
        
        if(conteo==2)
        {

            FunBotonesSub2();
            videoPlayer.Stop();
            videoPlayer.clip = historieta3;
            videoPlayer.Play();
            conteo=3;
            Puntuacion.text = "2/5";
            AnswerType.text="Correcto!";
            StartCoroutine("Esperar");
        }
        else
        {

            AnswerType.text="Incorrecto, inténtalo de nuevo:";
        }
        
    }

    public void Historieta3(){

        
        if(conteo==3)
        {
            FunBotonesSub3();
            videoPlayer.clip = historieta4;
            videoPlayer.Play();
            conteo=4;
            Puntuacion.text = "3/5";
            AnswerType.text="Correcto!";
            StartCoroutine("Esperar");
        }
        else
        {
            AnswerType.text="Incorrecto, inténtalo otra vez:";
        }
        
    }

    public void Historieta4(){

        
        if(conteo==4)
        {
            FunBotonesSub4();
            videoPlayer.clip= historieta5;
            videoPlayer.Play();
            conteo=5;
            Puntuacion.text = "4/5";
            AnswerType.text="Correcto!";
            StartCoroutine("Esperar");
        }
        else
		{
			AnswerType.text = "Incorrecto, inténtalo de nuevo:";
		}
    }

    public void Historieta5(){
        if(conteo==5)
        {
            Puntuacion.text = "5/5";
			AnswerType.text = "Correcto!";
            GameManager.nivel=0;
			SceneManager.LoadScene(3);

        }
        else
		{
			AnswerType.text = "Incorrecto, inténtalo de nuevo:";
		}
    }
    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(5);
        AnswerType.text="Menciona la persona :";
    }

    //Funciones para las opciones  de los botones
    void FunBotonesSub1()
    {
        CambioFunBotones1();
        textBot1.text= "Martha";
        textBot2.text= "Andrés ";
        textBot3.text= "Ninguna";
        textBot4.text= "El gato";
        textBot5.text= "Mama Martha";
        
    }
     void FunBotonesSub2()
    {
        CambioFunBotones2();
        textBot1.text= "Carlos";
        textBot2.text= "Tomás ";
        textBot3.text= "Amido de Carlos";
        textBot4.text= "Profesora";
        textBot5.text= "Ninguna";
    }

     void FunBotonesSub3()
    {
        CambioFunBotones3();
        textBot1.text= "Ana";
        textBot2.text= "Ninguna";
        textBot3.text= "Julio";
        textBot4.text= "Catalina";
        textBot5.text= "Carlos";
    }

     void FunBotonesSub4()
    {
        CambioFunBotones4();
        textBot1.text= "Andrea";
        textBot2.text= "Mamá de María";
        textBot3.text= "Ana";
        textBot4.text= "Catalina";
        textBot5.text= "María ";
    }

    //funciones para cambio de funcion de los botones
    public void FunInicialBotones()
    {
        sub1.onClick.AddListener(Historieta1);
        sub2.onClick.AddListener(FuncError);
        sub3.onClick.AddListener(FuncError);
        sub4.onClick.AddListener(FuncError);
        sub5.onClick.AddListener(FuncError);
    }
    public void CambioFunBotones1()
    {
        sub1.onClick.AddListener(FuncError);
        sub2.onClick.AddListener(Historieta2);
        sub3.onClick.AddListener(FuncError);
        sub4.onClick.AddListener(FuncError);
        sub5.onClick.AddListener(FuncError);
    }
    public void CambioFunBotones2()
    {
        sub1.onClick.AddListener(FuncError);
        sub2.onClick.AddListener(FuncError);
        sub3.onClick.AddListener(Historieta3);
        sub4.onClick.AddListener(FuncError);
        sub5.onClick.AddListener(FuncError);
    }
    public void CambioFunBotones3()
    {
        sub1.onClick.AddListener(FuncError);
        sub2.onClick.AddListener(FuncError);
        sub3.onClick.AddListener(FuncError);
        sub4.onClick.AddListener(Historieta4);
        sub5.onClick.AddListener(FuncError);
    }
    public void CambioFunBotones4()
    {
        sub1.onClick.AddListener(FuncError);
        sub2.onClick.AddListener(FuncError);
        sub3.onClick.AddListener(FuncError);
        sub4.onClick.AddListener(FuncError);
        sub5.onClick.AddListener(Historieta5);
    }

    public void FuncError()
    {
        AnswerType.text = "Incorrecto, inténtalo de nuevo:";
    }

    //Botones para el video
    public void PlayFunc()
    {
        videoPlayer.Play();
    }
    public void PauseFunc()
    {
        videoPlayer.Pause();
    }
    public void StopFunc()
    {
        videoPlayer.Stop();
    }
}
