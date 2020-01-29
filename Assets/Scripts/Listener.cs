using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    private void OnEnable()
    {
        GetHit.delegateHit += CallAmbulance;
    }

    private void OnDisable()
    {
        GetHit.delegateHit -= CallAmbulance;
    }

    void CallAmbulance()
    {
        Debug.Log("Düda");
    }
}
