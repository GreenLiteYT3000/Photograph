using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class PC : MonoBehaviour
{
    private int speed = 20;
   public float horizontal;
   public float vertical;
   private int rotateSpeed = 5;
   public float mouseHorizontal;

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        mouseHorizontal = Input.GetAxis("Mouse X");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
       transform.Rotate(Vector3.up * rotateSpeed * mouseHorizontal);
    }
}
