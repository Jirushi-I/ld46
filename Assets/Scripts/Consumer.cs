using System.Collections;
using System.Collections.Generic;
using ScriptableObjects.SerializedVariables;
using UnityEngine;

public class Consumer : MonoBehaviour
{
    [SerializeField] private SerializedVector playerPositionVector;
    
    [SerializeField] private SerializedBool isInteractingBool;
    
    [SerializeField] private SerializedFloat pickedUpLogsIntButItsAFloat;
    
    [SerializeField] private SerializedFloat countdownFloat;

    [SerializeField] private GameObject indicator;

    void Update()
    {
        if (Vector3.Distance(playerPositionVector.value, transform.position) > 1f || pickedUpLogsIntButItsAFloat.value < 0.1f)
        {
            indicator.SetActive(false);
            return;
        }
        indicator.SetActive(true);

        if (!isInteractingBool.value) return;

        countdownFloat.value += pickedUpLogsIntButItsAFloat.value * Mathf.Sqrt(Time.time);
        pickedUpLogsIntButItsAFloat.value=0;
    }
}
