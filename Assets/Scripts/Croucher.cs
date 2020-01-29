using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CollisionDetection))]

public class Croucher : MonoBehaviour
{
    [SerializeField]
    private GameObject ColliderStanding;

    [SerializeField]
    private GameObject colliderCcrouching;

    private CollisionDetection _collisionDetection;
    private bool _wantsToStandUp;

    public bool IsCrouching;

    void FixedUpdate()
    {
        if (_wantsToStandUp && CanStandUp()) StandUp();
    }

    public void OnCrouchStart()
    {
        ColliderStanding.SetActive(false);
        colliderCcrouching.SetActive(true);

        _wantsToStandUp = false;
        IsCrouching = true;
    }

    public void OnCrouchEnd()
    {
        _wantsToStandUp = true;
    }

    private void StandUp()
    {
        ColliderStanding.SetActive(true);
        colliderCcrouching.SetActive(false);

        _wantsToStandUp = false;
        IsCrouching = false;
    }

    private bool CanStandUp()
    {
        if (!_collisionDetection) _collisionDetection = GetComponent<CollisionDetection>();

        return !_collisionDetection.IsTouchingUp;
    }
}
