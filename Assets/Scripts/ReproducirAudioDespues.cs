using System.Collections;
using UnityEngine;

public class ReproducirAudioDespues : MonoBehaviour
{
    public AudioSource audioPrimero;
    public AudioSource audioSegundo;

    public float segundosEspera = 2f;

    void Start()
    {
        StartCoroutine(ReproducirSecuencia());
    }

    IEnumerator ReproducirSecuencia()
    {
        // Reproduce el primer audio
        audioPrimero.Play();

        // Espera mientras el primer audio se está reproduciendo
        while (audioPrimero.isPlaying)
        {
            yield return null;
        }

        // Espera N segundos después de que termine
        yield return new WaitForSeconds(segundosEspera);

        // Reproduce el segundo audio
        audioSegundo.Play();
    }
}