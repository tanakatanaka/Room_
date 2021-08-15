using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineDollyCartController : MonoBehaviour
{
    [SerializeField] CinemachineDollyCart _cinemachineDollyCart;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _cinemachineDollyCart.m_Speed = 2;
            return;
        }

        _cinemachineDollyCart.m_Speed = 0;
    }


    void SpeedUp()
    {
        _cinemachineDollyCart.m_Speed = 2;
    }


}
