using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaController : MonoBehaviour
{
    public WheelCollider onSol,onSag,arkaSol,arkaSag;
    public float motorHiz,donmeHizi;

    private void Update()
    {
        arkaSag.motorTorque = motorHiz * Input.GetAxis("Vertical");
        arkaSol.motorTorque = motorHiz * Input.GetAxis("Vertical");
        onSag.steerAngle = donmeHizi * Input.GetAxis("Horizontal");
        onSol.steerAngle = donmeHizi * Input.GetAxis("Horizontal");
    }
}
