using System;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    public InputAction action;
    public InputAction clickAction;
    public GameObject bullet;

    void Start()
    {
        action = InputSystem.actions.FindAction("Move");
        clickAction = InputSystem.actions.FindAction("Click");
        clickAction.performed += OnClick;
    }
    private void OnClick(InputAction.CallbackContext ctx)
    {
        Instantiate(bullet, transform.position + new Vector3(0.2f, 0, 0), Quaternion.identity);
    }
    private void Update()
    {
        Vector2 moveinput = action.ReadValue<Vector2>();
        Vector2 moveValue = new Vector2(0f, moveinput.y);
        _rb.linearVelocity = moveValue;
    }
}
