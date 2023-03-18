using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class MouseButton : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                return;
            }
        }
    }
}