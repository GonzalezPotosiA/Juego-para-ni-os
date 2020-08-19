
using System.Threading;
using System.Reflection;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PasarVideosDecisiones : MonoBehaviour
{
    private int tiempoInicial, pausaVideo;
    public float escalaDeTiempo=1;
    private float tiempoDelFrameConTimeScale=0f;
    public float tiempoMostrarEnSegundos=0f;
    private float escalaDeTiempoAlPausar, escalaDeTiempoInicial;
    private bool estaPausado=false;
    private bool Iniciar=true;
    private bool playVB = false;
    private bool playVC=false;
    private bool playVD=false;
    private bool playVE=false;
    private bool playVF=false;
    private bool playVG=false;
    private bool playVH=false;
    private bool playVI=false;
    private bool playVJ=false;
    private bool playVK=false;
    public VideoPlayer videoPlayer;
    public AudioSource fuenteAudio;
    public RawImage fondoBotonA, fondoBotonB;
    public VideoClip Video1,VideoA, VideoB, VideoC, VideoD, VideoE, VideoF, VideoG, VideoH, VideoI, VideoJ, VideoK;
    public Text pregunta, Decision1, Decision2, finalText;
    public Button Des1, Des2, op1, op2, BotonPause;

    

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        fuenteAudio = GetComponent<AudioSource>();
    }
    void Start()
    {
        escalaDeTiempoInicial= escalaDeTiempo;
        tiempoMostrarEnSegundos=tiempoInicial;
        ActualizarReloj(tiempoInicial);
        
    }

    void Update()
    {
        if(!estaPausado)
        {
            tiempoDelFrameConTimeScale= Time.deltaTime*escalaDeTiempo;
            tiempoMostrarEnSegundos+=tiempoDelFrameConTimeScale;
            ActualizarReloj(tiempoMostrarEnSegundos);
            if(tiempoMostrarEnSegundos>=5 && Iniciar==true)
            {
                InicioPrueba();
            }
            if(tiempoMostrarEnSegundos>=210 && tiempoMostrarEnSegundos<211 && playVB==true)
            {
                //Decision B
                Pausar();
                tiempoMostrarEnSegundos= 211;
                pausaVideo=2;
                pregunta.text="¿Qué deberían hacer?";
                Decision1.text = "Hablarle al niño";
                Decision2.text="No molestarlo y dejarlo solo";
                BotonActivar();
                Des1.onClick.AddListener(playVideoE);
                Des2.onClick.AddListener(playVideoD);
            } 
            if(tiempoMostrarEnSegundos>=120 && tiempoMostrarEnSegundos<121 && playVC==true)
            {
                //Decision C
                Pausar();
                tiempoMostrarEnSegundos= 106;
                pausaVideo=2;
                playVC=false;
                pregunta.text="¿Qué debería hacer Mateo?";
                Decision1.text = "Decirle su nombre";
                Decision2.text="Quedarse callado!";
                BotonActivar();
                Des1.onClick.AddListener(playVideoB);
                Des2.onClick.AddListener(playVideoC);
            } 

            if(tiempoMostrarEnSegundos>=255 && tiempoMostrarEnSegundos<256 && playVE==true)
            {
                //Decision E
                Pausar();
                playVE=false;
                tiempoMostrarEnSegundos= 256;
                pausaVideo=2;
                Decision1.text="No molestarlo y dejarlo solo";
                pregunta.text="Qué deberián hacer?";
                Des1.gameObject.SetActive(true);
                pregunta.gameObject.SetActive(true);
                Des1.onClick.AddListener(playVideoD);
                
            }
            if(tiempoMostrarEnSegundos>=317 && tiempoMostrarEnSegundos<318 && playVD==true)
            {
                //decision D
                Pausar();
                playVD=false;
                tiempoMostrarEnSegundos= 318;
                pausaVideo=2;
                pregunta.text="¿Qué deberían hacer Juliana y Mateo?";
                Decision1.text = "Ir a la sala de sistemas";
                Decision2.text="Hablar con la profesora";
                BotonActivar();
                Des1.onClick.AddListener(playVideoG);
                Des2.onClick.AddListener(playVideoF);
            }
            if(tiempoMostrarEnSegundos>=410 && tiempoMostrarEnSegundos<411 && playVG==true)
            {
                //decision G
                Pausar();
                playVG=false;
                tiempoMostrarEnSegundos= 411;
                pausaVideo=2;
                Decision1.text = "Hablar con la profesora";
                pregunta.text="Qué deberián hacer julina y Mateo?";
                Des1.gameObject.SetActive(true);
                pregunta.gameObject.SetActive(true);
                Des1.onClick.AddListener(playVideoF);
            }
            if(tiempoMostrarEnSegundos>=521 && tiempoMostrarEnSegundos<522 && playVF==true)
            {
                //decision F
                Pausar();
                playVF=false;
                tiempoMostrarEnSegundos= 522;
                pausaVideo=2;
                Decision1.text = "Ir a la sala de sistemas";
                pregunta.text="Qué deberian hacer Juliana y Mateo?";
                Des1.gameObject.SetActive(true);
                pregunta.gameObject.SetActive(true);
                Des1.onClick.AddListener(playVideoH);
            }
            if(tiempoMostrarEnSegundos>=619 && tiempoMostrarEnSegundos<620 && playVH==true)
            {
                //decision H
                Pausar();
                playVH=false;
                tiempoMostrarEnSegundos= 620;
                pausaVideo=2;
                pregunta.text="¿Qué quieres jugar?";
                Decision1.text = "Jugar futbol";
                Decision2.text="Jugar lleva";
                BotonActivar();
                Des1.onClick.AddListener(playVideoJ);
                Des2.onClick.AddListener(playVideoI);
            }
            if(tiempoMostrarEnSegundos>=645 && tiempoMostrarEnSegundos<646)
            {
                //decision J o I
                Pausar();
                playVI=false;
                playVJ=false;
                tiempoMostrarEnSegundos= 646;
                pausaVideo=2;
                Decision1.text = "Buscar más juegos";
                Des1.gameObject.SetActive(true);
                Des1.onClick.AddListener(playVideoK);
            }
            if(tiempoMostrarEnSegundos>=677 && tiempoMostrarEnSegundos<678 && playVK==true)
            {
                BotonPause.enabled=false;
                Pausar();
                finalText.gameObject.SetActive(true);
            }
        }
        
    }

    public void InicioPrueba(){
        
        BotonDesactivar();
        videoPlayer.clip= Video1;
        videoPlayer.Play();
        if(tiempoMostrarEnSegundos>=105 && tiempoMostrarEnSegundos<106)
        {
            
            videoPlayer.clip=VideoA;
            videoPlayer.Play();
            video();
        }
    }

    public void video()
    {
            Pausar();
            tiempoMostrarEnSegundos=106;
            pausaVideo=2;
            BotonActivar();
            pregunta.text="¿Qué debería hacer Mateo?";
            Decision1.text = "Decirle su nombre";
            Decision2.text="Quedarse callado!";
            Des1.onClick.AddListener(playVideoB);
            Des2.onClick.AddListener(playVideoC);
    }
    public void playVideoB(){
        //Continuar();
        playVB=true;
        pausaVideo=0;
        BotonDesactivar();
        videoPlayer.clip=VideoB;
        videoPlayer.Play();
        Iniciar=false;
        Continuar();
    }

    public void playVideoC(){
        playVC=true;
        BotonDesactivar();
        pausaVideo=0;
        videoPlayer.clip= VideoC;
        videoPlayer.Play();
        Iniciar=false;
        playVC=true;
        Continuar();
    }
    public void playVideoD(){
        playVD=true;
        tiempoMostrarEnSegundos=256;
        BotonDesactivar();
        pausaVideo=0;
        videoPlayer.clip=VideoD;
        videoPlayer.Play();
        Iniciar=false;
        Continuar();

    }

    public void playVideoE(){
        playVE=true;
        BotonDesactivar();
        pausaVideo=0;
        videoPlayer.clip=VideoE;
        videoPlayer.Play();
        Continuar();

    }

    public void playVideoF(){
        playVF=true;
        tiempoMostrarEnSegundos=411;
        BotonDesactivar();
        pausaVideo=0;
        videoPlayer.clip= VideoF;
        videoPlayer.Play();
        Continuar();
    }
    public void playVideoG(){
        playVG=true;
        tiempoMostrarEnSegundos=318;
        BotonDesactivar();
        pausaVideo=0;
        videoPlayer.clip= VideoG;
        videoPlayer.Play();
        Continuar();
    }

    public void playVideoH(){
        playVH=true;
        tiempoMostrarEnSegundos=522;
        BotonDesactivar();
        pausaVideo=0;
        videoPlayer.clip= VideoH;
        videoPlayer.Play();
        Continuar();
    }

    public void playVideoI(){
        playVI=true;
        tiempoMostrarEnSegundos=631;
        BotonDesactivar();
        pausaVideo=0;
        videoPlayer.clip= VideoI;
        videoPlayer.Play(); 
        Continuar();
    }
    public void playVideoJ(){
        playVJ=true;
        tiempoMostrarEnSegundos=620;
        BotonDesactivar();
        pausaVideo=0;
        videoPlayer.clip= VideoJ;
        videoPlayer.Play();
        Continuar();
    }

    public void playVideoK(){
        playVK=true;
        tiempoMostrarEnSegundos=646;
        BotonDesactivar();
        pausaVideo=0;
        videoPlayer.clip= VideoK;
        videoPlayer.Play();
        op1.gameObject.SetActive(false);
        op2.gameObject.SetActive(false);
        fondoBotonA.gameObject.SetActive(false);
        fondoBotonB.gameObject.SetActive(false);
        
    }

    public void BotonActivar(){
        
        Des1.gameObject.SetActive(true);
        Des2.gameObject.SetActive(true);
        pregunta.gameObject.SetActive(true);
    }

    public void BotonDesactivar(){
        
        Des1.gameObject.SetActive(false);
        Des2.gameObject.SetActive(false);
        pregunta.gameObject.SetActive(false);
        
    }

    //FUNCIONES DEL TIEMPO
    public void ActualizarReloj(float tiempoEnSegundos)
    {
        int minutos=0;
        int segundos=0;
        string textoReloj;

        if(tiempoEnSegundos<0)
        {
            tiempoEnSegundos=0;
        }

        minutos=(int)tiempoEnSegundos/60;
        segundos=(int)tiempoEnSegundos%60;

        textoReloj= minutos.ToString("00")+" :"+ segundos.ToString("00");
        //myText.text=textoReloj;
        
    }

    public void Pausar()
    {
        if(!estaPausado)
        {
            estaPausado=true;
            escalaDeTiempoAlPausar=escalaDeTiempo;
            escalaDeTiempo=0;
        }
    }
    public void Continuar()
    {
        if(estaPausado)
        {
            estaPausado=false;
            escalaDeTiempo= escalaDeTiempoAlPausar;
        }

    }
    public void Reiniciar()
    {
        estaPausado=false;
        escalaDeTiempo= escalaDeTiempoInicial;
        tiempoMostrarEnSegundos=tiempoInicial;
        ActualizarReloj(tiempoMostrarEnSegundos);
    }

    public void playVideo(){
        videoPlayer.Play();
        if(pausaVideo==1){
            Continuar();
            pausaVideo=0;
        }
    }

    public void pauseVideo()
    {
        if(pausaVideo==0){
            videoPlayer.Pause();
            pausaVideo=1;
            Pausar();
        }else if(pausaVideo==2){
            videoPlayer.Pause();
        }
    }

    public void Atras(){
        SceneManager.LoadScene(1);
    }
}

