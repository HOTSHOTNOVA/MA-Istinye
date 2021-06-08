using UnityEngine;

public class EndTrig : MonoBehaviour
{
    public GameObject GG;

    void OnTriggerEnter()
    {
        GG.SetActive(true);
    }
}
