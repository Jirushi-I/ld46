using UnityEngine;

namespace ScriptableObjects.SerializedVariables
{
    [CreateAssetMenu(menuName = "SerializedVariables/Float", fileName = "New Float")]
    public class SerializedFloat : ScriptableObject
    {
        public float value;

        public void Add(float value) => this.value += value;
        
        public void Reset() => value = 0;
    }
}
