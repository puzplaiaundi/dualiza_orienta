using UnityEngine;

public class TensiometroBlendShapes : MonoBehaviour
{
    public SkinnedMeshRenderer skinnedMeshRenderer;
    public float velocidad = 60f;

    private bool transformar = false;
    private float valor = 0f;

    void Update()
    {
        if (!transformar) return;

        valor += velocidad * Time.deltaTime;
        valor = Mathf.Clamp(valor, 0f, 100f);

        for (int i = 0; i < skinnedMeshRenderer.sharedMesh.blendShapeCount; i++)
        {
            skinnedMeshRenderer.SetBlendShapeWeight(i, valor);
        }
    }

    public void ActivarTransformacion()
    {
        transformar = true;
    }

    public void ResetearTransformacion()
    {
        transformar = false;
        valor = 0f;

        for (int i = 0; i < skinnedMeshRenderer.sharedMesh.blendShapeCount; i++)
        {
            skinnedMeshRenderer.SetBlendShapeWeight(i, 0f);
        }
    }
}