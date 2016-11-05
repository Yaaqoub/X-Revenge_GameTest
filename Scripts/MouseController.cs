/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour
{
    public float mouseSensitivity = 6.0f;
    public float upDownRange = 60;

    public GameObject fpsCamera;

    private float verticalRotation = 0;

    void Update()
    {
        float rotationLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;

        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.Rotate(0, rotationLeftRight, 0);

        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);

        fpsCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
    }
}
