using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Magenta : Cube
{
    // Start is called before the first frame update
    
    protected override void SetRotationDirection()
    {
        rotationDirection = Vector3.back;
    }

    protected override void StartRotate()
    {
        this.StatusRotate = true;
        StartCoroutine(StartRotating());
    }

    protected override void StopRotate()
    {
        this.StatusRotate = false;
        StopCoroutine(StartRotating());
    }

    IEnumerator StartRotating()
    {
        while(this.StatusRotate)
        {
            this.transform.Rotate(rotationDirection * rotationSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
