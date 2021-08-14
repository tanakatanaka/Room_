using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private Cinemachine.CinemachineSmoothPath path;

    void Update()
    {
        transform.position = path.EvaluatePositionAtUnit(0.5f, Cinemachine.CinemachinePathBase.PositionUnits.Normalized);
    }
}
