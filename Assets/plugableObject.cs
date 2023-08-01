using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plugableObject : MonoBehaviour
{
    [SerializeField] private List<AnchorTrigger> _triggers;

    public bool HasAttached(int triggerIndex)
    {
        if (triggerIndex < 0 || triggerIndex >= _triggers.Count)
        {
            return false;
        }

        return HasAttached(_triggers[triggerIndex]);
    }
    private static bool HasAttached(AnchorTrigger trigger)
    {
        return trigger.MyAnchor != null && trigger.MyAnchor.CurrentPlacedObject != null;
    }
}
