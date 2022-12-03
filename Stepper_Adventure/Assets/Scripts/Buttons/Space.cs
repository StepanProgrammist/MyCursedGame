using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    void OnBecameVisible()
    {
        Jump.IsSpaceVisible = true;
    }

    void OnBecameInvisible()
    {
        Jump.IsSpaceVisible = false;
    }

    void OnDestroy()
    {
        Jump.IsSpaceVisible = false;
    }
}
