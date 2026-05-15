using UnityEngine;
using TMPro;

public class CuentaAtrasJuego : MonoBehaviour
{
    [Header("Tiempo de juego")]
    public float tiempoInicial = 60f;


    [Header("Objetivos del juego")]
    public SocketConValidacion objetivoRam;
    public ObjetoFrotable objetivoCpu;

    [Header("Objetos a desactivar al finalizar")]
    public GameObject[] objetosADesactivar;
     [Header("Objetos a activar al finalizar")]
    public GameObject[] objetosActivar;

    [Header("Textos en pantalla")]
    public TMP_Text textoCuentaAtras;
    public TMP_Text textoPerdido;
    public TMP_Text textoSuperado;

    private float tiempoRestante;
    private bool juegoTerminado = false;
    private bool juegoSuperado = false;

    void Start()
    {
        tiempoRestante = tiempoInicial;

        if (textoPerdido != null)
        {
            textoPerdido.gameObject.SetActive(false);
        }
        
        if (textoSuperado != null)
        {
            textoSuperado.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (juegoTerminado)
            return;

        ComprobarExito();

        if (juegoSuperado)
        {
            SuperarJuego();
            return;
        }

        tiempoRestante -= Time.deltaTime;

        if (tiempoRestante <= 0)
        {
            tiempoRestante = 0;
            TerminarJuego();
        }

        ActualizarTextoTiempo();
    }

    void ActualizarTextoTiempo()
    {
        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);

        if (textoCuentaAtras != null)
        {
            textoCuentaAtras.text = minutos.ToString("00") + ":" + segundos.ToString("00");
        }
    }

void ComprobarExito()
{
    bool exitoRam = true;
    bool exitoCpu = true;

    if (objetivoRam != null)
    {
        exitoRam = objetivoRam.EstaConseguido();
    }

    if (objetivoCpu != null)
    {
        exitoCpu = objetivoCpu.EstaConseguido();
    }

    if (exitoRam && exitoCpu)
    {
        juegoSuperado = true;
    }
}

    void SuperarJuego()
    {
        juegoTerminado = true;

        if (textoCuentaAtras != null)
        {
            textoCuentaAtras.gameObject.SetActive(false);
        }

        if (textoSuperado!= null)
        {
            textoSuperado.gameObject.SetActive(true);
            
        }
        ActivarObjetosFinales();

        // Opcional:
        // Time.timeScale = 0f;
    }

    void TerminarJuego()
    {
        juegoTerminado = true;

        if (textoCuentaAtras != null)
        {
            textoCuentaAtras.gameObject.SetActive(false);
        }

        if (textoPerdido != null)
        {
            textoPerdido.gameObject.SetActive(true);

        }
        DesactivarObjetosFinales();

        // Opcional:
        // Time.timeScale = 0f;
    }
    void DesactivarObjetosFinales()
{
    foreach (GameObject obj in objetosADesactivar)
    {
        if (obj != null)
        {
            obj.SetActive(false);
        }
    }
}
    void ActivarObjetosFinales()
{
    foreach (GameObject obj in objetosActivar)
    {
        if (obj != null)
        {
            obj.SetActive(true);
        }
    }
}
}