using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{


    [SerializeField]
    private LayerMask WhatIsGround;

    [SerializeField]
    private Transform DownCheckPoint;

    [SerializeField]
    private Transform UpCheckPoint;

    [SerializeField]
    private Transform RightCheckPoint;

    [SerializeField]
    private Transform LeftCheckPoint;

    [SerializeField]
    private bool _isTouchingDown;
    public bool IsTouchingDown { get { return _isTouchingDown; } }

    [SerializeField]
    private bool _isTouchingUp;
    public bool IsTouchingUp { get { return _isTouchingUp; } }

    [SerializeField]
    private bool _isTouchingRight;
    public bool IsTouchingRight { get { return _isTouchingRight; } }

    [SerializeField]
    private bool _isTouchingLeft;
    public bool IsTouchingLeft { get { return _isTouchingLeft; } }

    private float checkRadius = 0.15f;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(UpCheckPoint.position, checkRadius);
        Gizmos.color = Color.white;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckDown();
        CheckUp();
        CheckRight();
        CheckLeft();
    }

    private void CheckDown()
    {
        var colliders = Physics2D.OverlapCircleAll(DownCheckPoint.position, checkRadius, WhatIsGround);

        _isTouchingDown = colliders.Length > 0;
    }


    private void CheckUp()
    {
        var colliders = Physics2D.OverlapCircleAll(UpCheckPoint.position, checkRadius, WhatIsGround);

        _isTouchingUp = colliders.Length > 0;
    }

    private void CheckRight()
    {
        var colliders = Physics2D.OverlapCircleAll(RightCheckPoint.position, checkRadius, WhatIsGround);

        _isTouchingRight = colliders.Length > 0;
    }

    private void CheckLeft()
    {
        var colliders = Physics2D.OverlapCircleAll(LeftCheckPoint.position, checkRadius, WhatIsGround);

        _isTouchingLeft = colliders.Length > 0;
    }
}