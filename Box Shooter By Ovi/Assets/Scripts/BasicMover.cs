using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    // Start is called before the first frame update

    // Define possible states of motion through enum data type

    public enum motionDirections {Spin , Horizontal , Vertical};

    // Store the state

    public motionDirections motionState = motionDirections.Horizontal;

    // Motion parameter
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;
    // Update is called once per frame
    void Update()
    {
        switch (motionState)
        {

            case motionDirections.Spin:
                // rotate around the up axix of the gameObject

                gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);

                break;


            case motionDirections.Vertical:

                // move up and down over time

                gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);



                break;

            case motionDirections.Horizontal:
                // move up and down over time
                gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
                break;











        }
        
    }
}


        