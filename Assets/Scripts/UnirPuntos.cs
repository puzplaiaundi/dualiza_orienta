using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class UnirPuntos : MonoBehaviour
{
    public Transform puntoA;
    public Transform puntoB;

    private LineRenderer lr;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();

        lr.useWorldSpace = true;
        lr.positionCount = 2;

        lr.startWidth = 0.002f;
        lr.endWidth = 0.002f;

        lr.enabled = false; // empieza oculta
    }

    void LateUpdate()
    {
        if (!lr.enabled) return;
        if (puntoA == null || puntoB == null) return;

        lr.SetPosition(0, puntoA.position);
        lr.SetPosition(1, puntoB.position);
    }

    public void MostrarLinea()
    {
        if (puntoA == null || puntoB == null) return;

        lr.enabled = true;
        lr.SetPosition(0, puntoA.position);
        lr.SetPosition(1, puntoB.position);
    }

    public void OcultarLinea()
    {
        lr.enabled = false;
    }
}