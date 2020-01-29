using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GetHit : MonoBehaviour
{

    public delegate void MyDelegate();
    public static MyDelegate delegateHit;

    public UnityEvent HitEvent;


    // Start is called before the first frame update
    void Start()
    {
        Hit();
    }

    void Hit ()
    {
        //delegateHit.Invoke();

        //HitEvent?.Invoke();

        BroadcastMessage("CallAmbulance");
    }

    void Die()
    {

    }

    void Recover()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
