using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorAppearance : MonoBehaviour
{
    [SerializeField] private Texture2D basic, clickableTarget, clickedTarget;
    private static CursorMode cursorMode = CursorMode.ForceSoftware;
    private static Vector2 hotSpotZero = Vector2.zero;
    private static Vector2 hotSpotBasic = new Vector2(20f, 5f);

    void Awake()
    {
        Basic();
    }

    public void Hardware()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    public void Basic()
    {
        Cursor.SetCursor(basic, hotSpotBasic, cursorMode);
    }

    public void ClickableTarget()
    {
        Cursor.SetCursor(clickableTarget, hotSpotZero, cursorMode);
    }

    public void ClickedTarget()
    {
        Cursor.SetCursor(clickedTarget, hotSpotZero, cursorMode);
    }
}