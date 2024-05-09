using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_look : MonoBehaviour
{
    [Header("References")]
    [Tooltip("Reference to the main camera used for the player")]
    public Camera PlayerCamera;

    public float mouseSensitivity = 25f;

    public Transform playerBody;


    //float xRotation = 0f;

    //Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            // float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            //float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            // xRotation -= mouseY;
            // xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            // transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            // playerBody.Rotate(Vector3.up * mouseX);

            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime, transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime, 0f);
            //transform.Rotate(new Vector3(transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * mouseSensitivity, transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mouseSensitivity, 0f), Space.Self);
        }
        
    }

   // public float GetLookInputsHorizontal()
    //{
        //return GetMouseOrStickLookAxis(GameConstants.k_MouseAxisNameHorizontal,
          //  GameConstants.k_AxisNameJoystickLookHorizontal);
    //}
}
