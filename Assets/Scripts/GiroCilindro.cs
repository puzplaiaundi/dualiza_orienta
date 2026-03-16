using UnityEngine;
using TMPro;

public class GiroCilindro : MonoBehaviour
{
    public Animator animator;
    public string nombreParametro = "girado";
    public int cont=0;
 

    void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }

    }

    public void CambiarEstado()
    {
        bool valorActual = animator.GetBool(nombreParametro);
        bool nuevoValor = !valorActual;

        animator.SetBool(nombreParametro, nuevoValor);

     
    }

    public void ActualizarTexto(TMP_Text texto)
    {
        bool estado = animator.GetBool(nombreParametro);

        if (estado)
        {
            texto.text = "Girado";
        }
        else
        {
            texto.text = "Sin girar";
        }
    }
    public void incrementarContador(TMP_Text contador)
    {
        contador.text= "Contador de giros = "+cont++;
    }
}