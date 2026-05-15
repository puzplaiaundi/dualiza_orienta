using UnityEngine;
using UnityEngine.InputSystem;

public class CepilloVR : MonoBehaviour
{
    [Header("Acciones de frotar")]
    public InputActionReference accionFrotarLateral;
    public InputActionReference accionFrotarFrontal;

    public bool estaFrotando;

    private void OnEnable()
    {
        if (accionFrotarLateral != null)
            accionFrotarLateral.action.Enable();

        if (accionFrotarFrontal != null)
            accionFrotarFrontal.action.Enable();
    }

    private void OnDisable()
    {
        if (accionFrotarLateral != null)
            accionFrotarLateral.action.Disable();

        if (accionFrotarFrontal != null)
            accionFrotarFrontal.action.Disable();
    }

    private void Update()
    {
        bool lateralPulsado = accionFrotarLateral != null && accionFrotarLateral.action.IsPressed();
        bool frontalPulsado = accionFrotarFrontal != null && accionFrotarFrontal.action.IsPressed();

        estaFrotando = lateralPulsado || frontalPulsado;
    }
}