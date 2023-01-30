using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserInput : MonoBehaviour
{
    public static bool isCursorWithinAppWindow;
    public static Vector2 movementVector, cameraVector;
    public static float sideStepInput;
    private static Vector2 screenDimensions;

    void Start()
    {
        screenDimensions = new Vector2(Screen.width, Screen.height);
    }

    public void OnCursorPosition(InputAction.CallbackContext ctx)
    {
        Vector2 position = ctx.ReadValue<Vector2>();
        isCursorWithinAppWindow = !(position.x < 0 || position.x > screenDimensions.x || position.y < 0 || position.y > screenDimensions.y);
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        movementVector = ctx.ReadValue<Vector2>();
    }

    public void OnSideStep(InputAction.CallbackContext ctx)
    {
        sideStepInput = ctx.ReadValue<float>();
    }

    public void OnLook(InputAction.CallbackContext ctx)
    {
        if (isCursorWithinAppWindow)
            cameraVector = ctx.ReadValue<Vector2>();
        else
            cameraVector = new Vector2(0f, 0f);
    }

    public void OnFire(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
            Debug.Log("Fire!");
    }
}
