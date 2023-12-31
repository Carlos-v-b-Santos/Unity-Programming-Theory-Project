using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cube : MonoBehaviour
{

    public bool StatusRotate { get; set; }
    [SerializeField] protected float rotationSpeed;
    [SerializeField] protected Vector3 rotationDirection;

    // Update is called once per frame

    void Start()
    {
        SetRotationDirection();
    }

    protected abstract void SetRotationDirection();
    public void ChangeState()
    {
        if (this.StatusRotate == false)
        {
            StartRotate();
        }
        else
        {
            StopRotate();
        }
    }

    protected virtual void StartRotate()
    // iniciar a rotacao
    {
        this.StatusRotate = true;
        Debug.Log("Comecou a rodar");
    }

    protected virtual void StopRotate()
    // interromper a rotacao
    {
        this.StatusRotate = false;
        Debug.Log("Parou de rodar");
    }
}
