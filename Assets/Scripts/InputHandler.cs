using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class InputHandler : MonoBehaviour
{
    public InputAction MoveAction;

    public InputActionMap gameplayActions;

    private void Awake()
    {
        MoveAction.performed += Move;
    }

    private void onEnable()
    {
        MoveAction.Enable();
    }

    private void onDisable()
    {
        MoveAction.Disable();
    }

    public void Move(CallbackContext context)
    {
        transform.Translate(context.action.ReadValue<Vector2>());
    }
}