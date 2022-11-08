using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    public static StackManager instance;
    [SerializeField] private float _distanceBetweenObjects;
    [SerializeField] private Transform _parent;
    [SerializeField] private Transform _prevObject;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        _distanceBetweenObjects = _prevObject.localScale.y;
    }
    public void PickUp(GameObject pickedObject)
    {
        pickedObject.transform.parent = _parent;
        Vector3 desPos = _prevObject.localPosition;
        desPos.y += _distanceBetweenObjects ;
        Quaternion desRot = _prevObject.localRotation;
        pickedObject.transform.localRotation = desRot;

        pickedObject.transform.localPosition = desPos;
        _prevObject = pickedObject.transform;
    }
}
