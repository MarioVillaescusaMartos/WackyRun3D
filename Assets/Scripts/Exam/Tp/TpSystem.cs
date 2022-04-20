using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TpSystem : MonoBehaviour
{
    public Transform tpPoint;

    public abstract void SetNewPosition();
}
