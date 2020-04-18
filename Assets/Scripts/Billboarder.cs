using ScriptableObjects.SerializedVariables;
using UnityEngine;
using UnityEngine.InputSystem;

public class Billboarder : MonoBehaviour
{
    [SerializeField] private TransformType typeOfVectorUsed;

    private enum TransformType
    {
        Position,
        Rotation,
    }
    
    [SerializeField] private SerializedVector usedCameraVector;

    void Update()
    {
        switch (typeOfVectorUsed)
        {
            case TransformType.Rotation:
                transform.eulerAngles = usedCameraVector.value;
                break;
            case TransformType.Position:
                transform.LookAt(usedCameraVector.value);
                break;
        }
    }
}

