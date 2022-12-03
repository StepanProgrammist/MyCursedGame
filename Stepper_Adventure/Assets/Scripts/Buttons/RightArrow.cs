using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrowButton : MonoBehaviour
{
    void OnBecameVisible()
    {
        Walking.IsRightButtonVisible = true;
    }

    void OnBecameInvisible()
    {
        Walking.IsRightButtonVisible = false;
    }

    void OnDestroy()
    {
        Walking.IsRightButtonVisible = false;
    }
}
