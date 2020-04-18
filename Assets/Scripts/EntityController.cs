using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjects.SerializedVariables;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class EntityController : MonoBehaviour
{
    private Vector2 _moveDirection;
    private CharacterController _controller;
    private SpriteRenderer _spriteRenderer;
    

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    private void FixedUpdate()
    {
        var position = transform.position;
        
        if (_moveDirection.x > 0)
            _spriteRenderer.flipX = false;
        else if (_moveDirection.x < 0)
            _spriteRenderer.flipX = true;
        
        _controller.Move(new Vector3(
                             _moveDirection.x,
                             0,
                             _moveDirection.y) * (Time.fixedDeltaTime * 5));
    }

    public void Move(InputAction.CallbackContext context) => _moveDirection = context.ReadValue<Vector2>();
    public void Move(Vector2 moveDirection) => _moveDirection = moveDirection.normalized;
}
