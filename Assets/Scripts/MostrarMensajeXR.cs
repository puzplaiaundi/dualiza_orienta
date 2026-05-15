using UnityEngine;

public class MostrarMensajeXR : MonoBehaviour
{
    public GameObject mensaje;

    public void Mostrar()
    {
        if (mensaje != null)
            mensaje.SetActive(true);
    }

    public void Ocultar()
    {
        if (mensaje != null)
            mensaje.SetActive(false);
    }

    public void Alternar()
    {
        if (mensaje != null)
            mensaje.SetActive(!mensaje.activeSelf);
    }
}