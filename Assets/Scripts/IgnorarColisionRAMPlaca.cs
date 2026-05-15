using UnityEngine;

public class IgnorarColisionRAMPlaca : MonoBehaviour
{
    public Collider[] collidersRAM;
    public Collider[] collidersPlaca;

    void Start()
    {
        foreach (Collider cRam in collidersRAM)
        {
            foreach (Collider cPlaca in collidersPlaca)
            {
                if (cRam != null && cPlaca != null)
                {
                    Physics.IgnoreCollision(cRam, cPlaca, true);
                }
            }
        }
    }
}
