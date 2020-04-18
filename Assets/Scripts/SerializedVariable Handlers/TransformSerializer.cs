using System.Collections;
using System.Collections.Generic;
using ScriptableObjects.SerializedVariables;
using UnityEngine;

public class TransformSerializer : MonoBehaviour
{
    [SerializeField] private SerializedVector positionVector;
    [SerializeField] private SerializedVector rotationEuler;
    [SerializeField] private SerializedVector scaleVector;

    private void Update()
    {
        SetVectorIfExists(positionVector, transform.position);
        SetVectorIfExists(rotationEuler, transform.eulerAngles);
        SetVectorIfExists(scaleVector, transform.localScale);
    }

    private void SetVectorIfExists(SerializedVector serializedVector, Vector3 value)
    {
        if (serializedVector)
            serializedVector.value = value;
    }
}
