using UnityEngine;

public class PanelMiraCamara : MonoBehaviour
{
    public Transform camara;

    void LateUpdate()
    {
        if (camara == null) return;

        transform.LookAt(transform.position + camara.forward, camara.up);
    }
}