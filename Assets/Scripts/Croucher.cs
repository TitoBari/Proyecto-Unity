using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croucher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCrouchStart()
    {
        Debug.Log("start crouch");
    }

    public void OnCrouchEnd()
    {
        Debug.Log("end crouch");
    }
}
