using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   //Variables
   [SerializeField] private float mouseSensitiviy;

   //References
   private Transform parent;

   private void Start()
   {
        parent = transform.parent;
        Cursor.lockState = CursorLockMode.Locked;
   }

   private void Update()
   {
        Rotate();
   }

   private void Rotate()
   {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitiviy * Time.deltaTime;

        parent.Rotate(Vector3.up, mouseX);
   }
}
