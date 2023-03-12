using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    [Header("Mouse Info")]
    public Vector3 clickStartLocation;

    [Header("Physics")]
    public Vector3 launchVector;
    public float launchForce;

    [Header("Slime")]
    public Transform slimeTransform;
    public Rigidbody slimeRigidbody;
    public Vector3 originalSlimePosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDifference = clickStartLocation = Input.mousePosition;
            launchVector = new Vector3(
                mouseDifference.x * 1.5f,
                mouseDifference.y * 2f,
                mouseDifference.y * 2.5f
               );
            slimeTransform.position = originalSlimePosition - launchVector / 400;
            launchVector.Normalize();
        }
        if (Input.GetMouseButtonUp(0))
        {
            slimeRigidbody.isKinematic = false;
            slimeRigidbody.AddForce(launchVector * -launchForce, ForceMode.Impulse);
        }

        if (Input.GetKeyDown("space"))
        {
            slimeRigidbody.isKinematic = true;
            originalSlimePosition = new Vector3(158, 233, 13);
            slimeTransform.position = originalSlimePosition;
            slimeTransform.rotation = Quaternion.identity;
        }
    }
}
