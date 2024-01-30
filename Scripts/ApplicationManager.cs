@Author: Vinicius Chrisosthemos Teixeira

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    //[SerializeField] private CharacterController characterController;
    [SerializeField] private CharacterCameraConstraint characterController;
    [SerializeField] private float heightSpeed;

    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.Two))
        {
            ChangeHeight(true);
        }


        if (OVRInput.GetUp(OVRInput.Button.One))
        {
            ChangeHeight(false);
        }
    }
    /*
    public void ChangeHeight(bool toIncrease)
    {
        int signal = toIncrease ? 1 : -1;

        characterController.height += heightSpeed * signal;
    }*/

    public void ChangeHeight(bool toIncrease)
    {
        int signal = toIncrease ? 1 : -1;

        characterController.HeightOffset += heightSpeed * signal;
    }
}
