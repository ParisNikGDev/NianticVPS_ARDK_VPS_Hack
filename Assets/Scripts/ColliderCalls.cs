using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCalls : MonoBehaviour
{
    public static Action<Vector3> CollisionEntered;
    public static Action CollisionExit;
    public void OnCollisionEnter(Collision collision)
    {
        CollisionEntered?.Invoke(collision.contacts[0].point);
    }
    public void OnCollisionExit(Collision collision)
    {
        CollisionExit?.Invoke();
    }
}
