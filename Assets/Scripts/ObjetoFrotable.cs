using UnityEngine;

public class ObjetoFrotable : MonoBehaviour
{
    public float progreso = 0f;
    public float velocidad = 0.5f;

    public GameObject objetoActivable;

    public GameObject objetoDesactivable;

    private Renderer rend;
    private Color colorInicial;

    private bool conseguido;

    private void Start()
    {
        conseguido = false;

        rend = GetComponent<Renderer>();

        if (objetoActivable != null)
        {
            objetoActivable.SetActive(false);
        }

        if (rend != null)
        {
            colorInicial = rend.material.color;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        CepilloVR cepillo = other.GetComponent<CepilloVR>();

        if (cepillo == null || !cepillo.estaFrotando || rend == null)
            return;

        progreso += velocidad * Time.deltaTime;
        progreso = Mathf.Clamp01(progreso);

        rend.material.color = Color.Lerp(colorInicial, Color.yellow, progreso);

        if (progreso == 1)
        {
            if (!conseguido)
            {
                if (objetoActivable != null)
                {
                    objetoActivable.SetActive(true);

                }
                if (objetoDesactivable != null)
                {
                    
                    objetoDesactivable.SetActive(false);
                }

                conseguido = true;
            }
        }
    }

    public bool EstaConseguido()
    {
        return conseguido;
    }
}