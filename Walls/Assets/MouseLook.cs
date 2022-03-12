using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2,
    }

    public RotationAxes axes = RotationAxes.MouseXAndY;
 
    void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            // horizontal rotation here
        }
        else if (axes == RotationAxes.MouseY)
        {
            // vertical rotation here
        }
        else
        {
            // both horizontal and vertical rotation here
        }
    }
}
