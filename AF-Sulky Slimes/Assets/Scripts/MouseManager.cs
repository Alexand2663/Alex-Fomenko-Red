using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    [Header("Lives")]
    public LivesManager livesManager;

    // Update is called once per frame
    void Update()
    {
        if(livesManager.lives <= 0)
        {
            SceneManager.LoadScene(0);
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDifference = clickStartLocation - Input.mousePosition;
            launchVector = new Vector3(
                mouseDifference.x * -1f,
                mouseDifference.y * 1.1f,
                mouseDifference.y * -1.2f
               );
            launchForce = mouseDifference.y;
            slimeTransform.position = originalSlimePosition - launchVector / 400;
            launchVector.Normalize();
        }
        if (Input.GetMouseButtonUp(0))
        {
            livesManager.RemoveLife();
            slimeRigidbody.isKinematic = false;
            slimeRigidbody.AddForce(launchVector * launchForce, ForceMode.Impulse);
        }

        if (Input.GetKeyDown("space"))
        {
            slimeRigidbody.isKinematic = true;
            originalSlimePosition = new Vector3(386.310211f, 232.373993f, 142.40744f);
            slimeTransform.position = originalSlimePosition;
            slimeTransform.rotation = Quaternion.identity;
        }
    }
}
