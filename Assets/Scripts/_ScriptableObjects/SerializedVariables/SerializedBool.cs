using UnityEngine;

namespace ScriptableObjects.SerializedVariables
{
    [CreateAssetMenu(menuName = "SerializedVariables/Boolean", fileName = "New Bool")]
    public class SerializedBool : ScriptableObject
    {
        public bool value;
    }
}
