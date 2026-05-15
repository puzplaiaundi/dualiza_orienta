using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Esta variable aparecerá en el Inspector de cada escena
    public string sceneToLoad; 

    // Este es el método que llamarás desde el Animation Event
    public void ExecuteLoad()
    {
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("¡No has puesto nombre de escena en el Inspector!");
        }
    }

    // Mantienes este por si lo usas en otros sitios
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}