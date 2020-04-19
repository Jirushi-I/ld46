using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ScriptableObjects.SerializedVariables
{
    [CreateAssetMenu(menuName = "SerializedVariables/Boolean", fileName = "New Bool")]
    public class SerializedBool : ScriptableObject
    {
        public bool value;

        public void Set(InputAction.CallbackContext context) => value = context.ReadValueAsButton();
    }
}
