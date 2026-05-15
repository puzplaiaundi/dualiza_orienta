using UnityEngine;
using UnityEngine.Video;

public class MostrarAlFinalVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject elementoAMostrar;

    void Start()
    {
        if (elementoAMostrar != null)
            elementoAMostrar.SetActive(false);

        if (videoPlayer != null)
            videoPlayer.loopPointReached += AlTerminarVideo;
    }

    void AlTerminarVideo(VideoPlayer vp)
    {
        if (elementoAMostrar != null)
            elementoAMostrar.SetActive(true);
    }

    void OnDestroy()
    {
        if (videoPlayer != null)
            videoPlayer.loopPointReached -= AlTerminarVideo;
    }
}