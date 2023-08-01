using System;
using System.Collections;
using System.Collections.Generic;
using UltimateXR.Manipulation;
using UnityEngine;

[Serializable]
public class AnchorTrigger
{
    [SerializeField] private UxrGrabbableObjectAnchor _myAnchor;

    public UxrGrabbableObjectAnchor MyAnchor => _myAnchor;

}
