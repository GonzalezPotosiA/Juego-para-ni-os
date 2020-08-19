
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PasarVideosEjercicios : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public AudioSource fuenteAudio;
    public VideoClip Video1, Video2, Video3, Video4, Video5, Video6, Video7;
    public AudioClip AudioV1, AudioV2, AudioV3, AudioV4, AudioV5, AudioV6, AudioV7;
    public Text AnswerType;
    public int conteo1=0,conteo2=0,conteo3=0,conteo4=0,conteo5=0,conteo6=0,conteo7=0;
    public Button carta1, carta2, carta3, carta4, carta5, carta6, carta7;
    public RawImage unoIm, dosIm, tresIm, cuatroIm, cincoIm, seisIm, sieteIm;

    

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        fuenteAudio = GetComponent<AudioSource>();

    }
    void Start()
    {
        GameManager.nivel=4;
        carta1.onClick.AddListener(playVideo1);
        carta2.onClick.AddListener(playVideo2);
        carta3.onClick.AddListener(playVideo3);
        carta4.onClick.AddListener(playVideo4);
        carta5.onClick.AddListener(playVideo5);
        carta6.onClick.AddListener(playVideo6);
        carta7.onClick.AddListener(playVideo7);
    }


    

    public void Atras(){
        SceneManager.LoadScene(1);
    }

    public void Continuar(){
        SceneManager.LoadScene(8);
    }

   //Funciones para el cambio de historieta

    public void playVideo1(){
  
            AnswerType.text = "PREPARATE E IMITA";
            deshabilitar1();
            videoPlayer.Stop();
            videoPlayer.clip= Video1;
            videoPlayer.Play();
            //StartCoroutine("Esperar");

    }
    public void playVideo2()
    {
            AnswerType.text = "PONTE DE LADO E INTENTA OTRA VEZ";
            deshabilitar2();
            videoPlayer.clip = Video2;
            videoPlayer.Play();
            //StartCoroutine("Esperar");
    }

    public void playVideo3(){
 
            AnswerType.text = "VAMOS A SALTAR";
            deshabilitar3();
            videoPlayer.clip = Video3;
            videoPlayer.Play();
            //StartCoroutine("Esperar");
       
        
    }

    public void playVideo4(){

            AnswerType.text="PIES ATRAS";
            deshabilitar4();
            videoPlayer.clip= Video4;
            videoPlayer.Play();
            //StartCoroutine("Esperar");
        
    }

    public void playVideo5(){

            AnswerType.text="MUEVE LAS MANOS";
            deshabilitar5();
            videoPlayer.clip= Video5;
            videoPlayer.Play();
            //StartCoroutine("Esperar");

    }

    public void playVideo6(){
        
            AnswerType.text ="SALTO LATERAL";
            deshabilitar6();
            videoPlayer.clip= Video6;
            videoPlayer.Play();
            //StartCoroutine("Esperar");

    }

    public void playVideo7(){
        
            AnswerType.text ="SIENTATE Y PRACTICA";
            deshabilitar7();
            videoPlayer.clip= Video7;
            videoPlayer.Play();
            //StartCoroutine("Esperar");

    }
 

    //funciones para hablitar o desabilitar cartas

    public void deshabilitar1(){

        unoIm.GetComponent<RawImage>().enabled = false;
        

        unoIm.GetComponent<RawImage>().enabled = false;
        dosIm.GetComponent<RawImage>().enabled = true;
        tresIm.GetComponent<RawImage>().enabled = true;
        cuatroIm.GetComponent<RawImage>().enabled = true;
        cincoIm.GetComponent<RawImage>().enabled = true;
        seisIm.GetComponent<RawImage>().enabled = true;
        sieteIm.GetComponent<RawImage>().enabled = true;

    }
    public void deshabilitar2(){
        
        unoIm.GetComponent<RawImage>().enabled = true;
        dosIm.GetComponent<RawImage>().enabled = false;
        tresIm.GetComponent<RawImage>().enabled = true;
        cuatroIm.GetComponent<RawImage>().enabled = true;
        cincoIm.GetComponent<RawImage>().enabled = true;
        seisIm.GetComponent<RawImage>().enabled = true;
        sieteIm.GetComponent<RawImage>().enabled = true;
    }

    public void deshabilitar3(){
        unoIm.GetComponent<RawImage>().enabled = true;
        dosIm.GetComponent<RawImage>().enabled = true;
        tresIm.GetComponent<RawImage>().enabled = false;
        cuatroIm.GetComponent<RawImage>().enabled = true;
        cincoIm.GetComponent<RawImage>().enabled = true;
        seisIm.GetComponent<RawImage>().enabled = true;
        sieteIm.GetComponent<RawImage>().enabled = true;
    }

    public void deshabilitar4(){
        
        
        unoIm.GetComponent<RawImage>().enabled = true;
        dosIm.GetComponent<RawImage>().enabled = true;
        tresIm.GetComponent<RawImage>().enabled = true;
        cuatroIm.GetComponent<RawImage>().enabled = false;
        cincoIm.GetComponent<RawImage>().enabled = true;
        seisIm.GetComponent<RawImage>().enabled = true;
        sieteIm.GetComponent<RawImage>().enabled = true;
    }

    public void deshabilitar5(){
        unoIm.GetComponent<RawImage>().enabled = true;
        dosIm.GetComponent<RawImage>().enabled = true;
        tresIm.GetComponent<RawImage>().enabled = true;
        cuatroIm.GetComponent<RawImage>().enabled = true;
        cincoIm.GetComponent<RawImage>().enabled = false;
        seisIm.GetComponent<RawImage>().enabled = true;
        sieteIm.GetComponent<RawImage>().enabled = true;
    }

    public void deshabilitar6(){
        unoIm.GetComponent<RawImage>().enabled = true;
        dosIm.GetComponent<RawImage>().enabled = true;
        tresIm.GetComponent<RawImage>().enabled = true;
        cuatroIm.GetComponent<RawImage>().enabled = true;
        cincoIm.GetComponent<RawImage>().enabled = true;
        seisIm.GetComponent<RawImage>().enabled = false;
        sieteIm.GetComponent<RawImage>().enabled = true;
    }

    public void deshabilitar7(){
        unoIm.GetComponent<RawImage>().enabled = true;
        dosIm.GetComponent<RawImage>().enabled = true;
        tresIm.GetComponent<RawImage>().enabled = true;
        cuatroIm.GetComponent<RawImage>().enabled = true;
        cincoIm.GetComponent<RawImage>().enabled = true;
        seisIm.GetComponent<RawImage>().enabled = true;
        sieteIm.GetComponent<RawImage>().enabled = false;
    }

    public void FuncError()
    {
        AnswerType.text = "Incorrecto, inténtalo de nuevo:";
    }

    //Botones para el video
    public void PlayFunc()
    {
        videoPlayer.Play();
        fuenteAudio.Play();
    }
    public void PauseFunc()
    {
        videoPlayer.Pause();
        fuenteAudio.Pause();
    }
    public void StopFunc()
    {
        videoPlayer.Stop();
        fuenteAudio.Stop();
    }
}
