using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrowButton : MonoBehaviour
{
    void OnBecameVisible()
    {
        Walking.IsLeftButtonVisible = true;
    }

    void OnBecameInvisible()
    {
        Walking.IsLeftButtonVisible = false;
    }

    void OnDestroy()
    {
        Walking.IsLeftButtonVisible = false;
    }
}
