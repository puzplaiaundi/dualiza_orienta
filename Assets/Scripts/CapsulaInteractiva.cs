using UnityEngine;

public class CapsulaInteractiva : MonoBehaviour
{
    Animator anim;
    bool abierta = false;

    void Start()
    {
        anim.GetComponent<Animator>();
    }

    public void ToggleCapsula()
    {
        abierta = !abierta;
        anim.SetBool("abierta",abierta);
    }

    
}
