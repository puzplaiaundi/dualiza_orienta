using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOutActivate : MonoBehaviour
{
    public GameObject fadeout;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
      public void ActivateFadeout()
    {
        fadeout.SetActive(true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
