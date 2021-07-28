using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleBotController : MonoBehaviour
{
    public float targetV;
    public float targetAV;

    public Vector3 velocityRobot;
    public Vector3 angularVelocityRobot;

    public void forward() 
    {
        velocityRobot = new Vector3(0, 0, targetV);
    }

    public void backward()
    {
        velocityRobot = new Vector3(0, 0, -targetV);
    }

    public void left()
    {
        angularVelocityRobot = new Vector3(0, -targetAV, 0);
    }

    public void right()
    {
        angularVelocityRobot = new Vector3(0, targetAV, 0);
    }

    public void stop()
    {
        velocityRobot = Vector3.zero;
        angularVelocityRobot = Vector3.zero;
    }
}
