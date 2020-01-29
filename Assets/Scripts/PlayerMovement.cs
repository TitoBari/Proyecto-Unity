using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Croucher _croucher;
    public bool IsCrouching => _croucher.IsCrouching;

    float Speed => IsCrouching ? 10 : 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
