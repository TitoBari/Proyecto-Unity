using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    [SerializeField]
    private List<Transform> Targets;

    [SerializeField]
    private float Position_Z;

    [SerializeField]
    [Range(0.1f, 1000)]
    private float Smoothing = 10;

    [SerializeField]
    Vector2 DeadZone = new Vector2(0.2f, 0.15f);


    private Camera _camera;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!InDeadZone()) MoveToTarget();
    }

    private bool InDeadZone()
    {
        return false;
        /*Vector2 screenPositionPlayer = _camera.WorldToViewportPoint(Targets.position);

        if (screenPositionPlayer.x > (0.5f + DeadZone.x)) return false;

        if (screenPositionPlayer.x < (0.5f - DeadZone.x)) return false;

        if (screenPositionPlayer.y > (0.5f + DeadZone.y)) return false;

        if (screenPositionPlayer.y < (0.5f - DeadZone.y)) return false;

        return true;*/
    }

    private Vector3 GetTargetPosition()
    {

        var sum = Vector3.zero;

        foreach (var target in Targets)
        {
            sum += target.position;
        }

        return sum / Targets.Count;
    }

    void MoveToTarget()
    {
        Vector3 target = GetTargetPosition();

        target.z = Position_Z;

        transform.position = Vector3.Lerp(transform.position, target, Smoothing * Time.deltaTime);
    }
}
