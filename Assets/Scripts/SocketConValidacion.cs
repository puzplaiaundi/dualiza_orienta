using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class SocketConValidacion : MonoBehaviour
{
    public XRSocketInteractor socket;
    public XRGrabInteractable piezaBuena;

    public GameObject mensajeAcierto;
    public GameObject panelFinal;
    public GameObject mensajeError;

    private bool conseguidoRam = false;

    private void Awake()
    {
        if (socket == null)
            socket = GetComponent<XRSocketInteractor>();

        conseguidoRam = false;

        OcultarMensajes();
    }

    private void OnEnable()
    {
        if (socket != null)
        {
            socket.selectEntered.AddListener(AlEncajar);
            socket.selectExited.AddListener(AlDesencajar);
        }
    }

    private void OnDisable()
    {
        if (socket != null)
        {
            socket.selectEntered.RemoveListener(AlEncajar);
            socket.selectExited.RemoveListener(AlDesencajar);
        }
    }

    private void AlEncajar(SelectEnterEventArgs args)
    {
        OcultarMensajes();

        XRGrabInteractable piezaEncajada = args.interactableObject as XRGrabInteractable;

        if (piezaEncajada == null)
        {
            MostrarError();
            conseguidoRam = false;
            return;
        }

        if (piezaEncajada == piezaBuena)
        {
            MostrarAcierto();
            conseguidoRam = true;
        }
        else
        {
            MostrarError();
            conseguidoRam = false;
        }
    }

    private void AlDesencajar(SelectExitEventArgs args)
    {
        conseguidoRam = false;
        OcultarMensajes();
    }

    private void MostrarAcierto()
    {
        if (mensajeAcierto != null)
            mensajeAcierto.SetActive(true);

        if (panelFinal != null)
        {
            panelFinal.SetActive(true);
        }


        if (mensajeError != null)
            mensajeError.SetActive(false);
    }

    private void MostrarError()
    {
        if (mensajeError != null)
            mensajeError.SetActive(true);

        if (mensajeAcierto != null)
            mensajeAcierto.SetActive(false);
    }

    private void OcultarMensajes()
    {
        if (mensajeAcierto != null)
            mensajeAcierto.SetActive(false);

        if (mensajeError != null)
            mensajeError.SetActive(false);
    }

    public bool EstaConseguido()
    {
        return conseguidoRam;
    }
}