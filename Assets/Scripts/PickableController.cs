using System.Collections;
using System.Collections.Generic;
using ScriptableObjects.SerializedVariables;
using UnityEngine;

public class PickableController : MonoBehaviour
{
    [SerializeField] private SerializedVector playerPositionVector;
    
    [SerializeField] private SerializedBool isInteractingBool;
    
    [SerializeField] private SerializedFloat pickedUpLogsIntButItsAFloat;
    
    [SerializeField] private GameObject indicator;

    void Update()
    {
        if (Vector3.Distance(playerPositionVector.value, transform.position) > 1f || pickedUpLogsIntButItsAFloat.value > 4.5f)
        {
            indicator.SetActive(false);
            return;
        }
        indicator.SetActive(true);

        if (!isInteractingBool.value) return;

        pickedUpLogsIntButItsAFloat.value++;
        Destroy(gameObject);
    }
}
