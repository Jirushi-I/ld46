using UnityEngine;

namespace ScriptableObjects.SerializedVariables
{
    [CreateAssetMenu(menuName = "SerializedVariables/Vector", fileName = "New Vector")]
    public class SerializedVector : ScriptableObject
    {
        public Vector3 value;
    }
}
