
using System.Linq;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PasarCartas : MonoBehaviour
{
    
    public AudioSource fuenteAudio;
    public AudioClip Audio;
    public Text AnswerType, FinalAnswer;
    public int  contador2=0, rand=0;
    public RawImage carta1, carta2, carta3, carta4, carta5, carta6, carta7;
    
    

    void Awake()
    {
        fuenteAudio = GetComponent<AudioSource>();

    }
    void Start()
    {
        Empezar();
    }

    public void Empezar()
    {
        
        AnswerType.text="PREPARATE! Ahora practicaremos lo que acabas de aprender";
        //yield return new WaitForSeconds(10f);
        
        fuenteAudio.clip=Audio;
        fuenteAudio.Play();
        
        StartCoroutine(EjerciciosAleatorios());

    }

    IEnumerator EjerciciosAleatorios()
    {
        
        
        yield return new WaitForSeconds(10f);
        rand = UnityEngine.Random.Range(1,7);
        if(rand==1)
        {
            AnswerType.text="PONTE DE FRENTE! Toca tus hombros, rodillas y pies";
            habilitar1();
            
        } 
        else if(rand == 2)
        {
            AnswerType.text="PONTE DE LADO! toca tus hombros, rodillas y pies";
            habilitar2();
            
        }
        else if(rand==3)
        {
            AnswerType.text="SALTEMOS!";
            habilitar3();
            
        }
        else if(rand==4)
        {
            AnswerType.text="PIES ATRAS";
            habilitar4();
            
        }
        else if(rand==5)
        {
            AnswerType.text="MUEVE LAS MANOS";
            habilitar5();
            
        }
        else if(rand==6){
            AnswerType.text="SALTO LATERAL";
            habilitar6();
            
        }
        else if(rand==7)
        {
            AnswerType.text="SIENTATE! toca tus hombros, rodillas y pies";
            habilitar7();
            
        }

        if(contador2<=18)
        {
            contador2++;
            StartCoroutine(EjerciciosAleatorios());
        }else
        {
            AnswerType.text="TERMINASTE!";
            FinalAnswer.text="Gracias por participar, te esperamos pronto!";
        }

        
       
    }

    //funciones para hablitar o desabilitar cartas

    public void habilitar1(){

        carta1.GetComponent<RawImage>().enabled = true;
        carta2.GetComponent<RawImage>().enabled = false;
        carta3.GetComponent<RawImage>().enabled = false;
        carta4.GetComponent<RawImage>().enabled = false;
        carta5.GetComponent<RawImage>().enabled = false;
        carta6.GetComponent<RawImage>().enabled = false;
        carta7.GetComponent<RawImage>().enabled = false;

    }
    public void habilitar2(){
        
      
        carta1.GetComponent<RawImage>().enabled = false;
        carta2.GetComponent<RawImage>().enabled = true;
        carta3.GetComponent<RawImage>().enabled = false;
        carta4.GetComponent<RawImage>().enabled = false;
        carta5.GetComponent<RawImage>().enabled = false;
        carta6.GetComponent<RawImage>().enabled = false;
        carta7.GetComponent<RawImage>().enabled = false;
    }

    public void habilitar3(){
        
        carta1.GetComponent<RawImage>().enabled = false;
        carta2.GetComponent<RawImage>().enabled = false;
        carta3.GetComponent<RawImage>().enabled = true;
        carta4.GetComponent<RawImage>().enabled = false;
        carta5.GetComponent<RawImage>().enabled = false;
        carta6.GetComponent<RawImage>().enabled = false;
        carta7.GetComponent<RawImage>().enabled = false;
    }

    public void habilitar4(){
        
        carta1.GetComponent<RawImage>().enabled = false;
        carta2.GetComponent<RawImage>().enabled = false;
        carta3.GetComponent<RawImage>().enabled = false;
        carta4.GetComponent<RawImage>().enabled = true;
        carta5.GetComponent<RawImage>().enabled = false;
        carta6.GetComponent<RawImage>().enabled = false;
        carta7.GetComponent<RawImage>().enabled = false;
    }

    public void habilitar5(){
        
        carta1.GetComponent<RawImage>().enabled = false;
        carta2.GetComponent<RawImage>().enabled = false;
        carta3.GetComponent<RawImage>().enabled = false;
        carta4.GetComponent<RawImage>().enabled = false;
        carta5.GetComponent<RawImage>().enabled = true;
        carta6.GetComponent<RawImage>().enabled = false;
        carta7.GetComponent<RawImage>().enabled = false;
    }

    public void habilitar6(){
        
        carta1.GetComponent<RawImage>().enabled = false;
        carta2.GetComponent<RawImage>().enabled = false;
        carta3.GetComponent<RawImage>().enabled = false;
        carta4.GetComponent<RawImage>().enabled = false;
        carta5.GetComponent<RawImage>().enabled = false;
        carta6.GetComponent<RawImage>().enabled = true;
        carta7.GetComponent<RawImage>().enabled = false;
    }

    public void habilitar7(){

        
        carta1.GetComponent<RawImage>().enabled = false;
        carta2.GetComponent<RawImage>().enabled = false;
        carta3.GetComponent<RawImage>().enabled = false;
        carta4.GetComponent<RawImage>().enabled = false;
        carta5.GetComponent<RawImage>().enabled = false;
        carta6.GetComponent<RawImage>().enabled = false;
        carta7.GetComponent<RawImage>().enabled = true;
        
    }

    public void FuncBack()
    {
        SceneManager.LoadScene(7);
    }

   
}
