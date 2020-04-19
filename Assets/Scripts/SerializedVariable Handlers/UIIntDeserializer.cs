using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjects.SerializedVariables;
using TMPro;
using UnityEngine;

public class UIIntDeserializer : MonoBehaviour
{
    [SerializeField] private SerializedFloat serializedFloat;
    private TextMeshProUGUI _textMesh;

    private void Awake()
    {
        _textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        _textMesh.text = ((int)serializedFloat.value).ToString();
    }
}
