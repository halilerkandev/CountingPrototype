using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class DragAndShoot : MonoBehaviour
{
    private Vector3 _mousePressDownPos;
    private Vector3 _mouseReleasePos;

    private Rigidbody _rb;
    private bool _isShoot;

    [SerializeField]
    private float _forceMultiplier = 3.0f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        _mousePressDownPos = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        _mouseReleasePos = Input.mousePosition;
        Shoot(_mouseReleasePos - _mousePressDownPos);
    }

    public void Shoot(Vector3 force)
    {
        if (_isShoot)
            return;

        _rb.AddForce(new Vector3(force.x, force.y, force.y) * _forceMultiplier);
        _isShoot = true;
    }
}
