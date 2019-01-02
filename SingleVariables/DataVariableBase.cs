﻿using UnityEngine;
using UnityEngine.Events;

public class DataVariableBase : ScriptableObject
{
    
    //might not need
    public UnityEvent EnableEvent;
    public UnityEvent DisableEvent;
    
    public void OnEnable()
    {
        EnableEvent.Invoke();
    }

    public void OnDisable()
    {
        DisableEvent.Invoke();
    }
}