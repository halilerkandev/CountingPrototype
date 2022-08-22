using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitCounter : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _hitText;

    private int Count = 0;

    private void Start()
    {
        Count = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Count += 1;
        _hitText.text = "Hit: " + Count;
        Destroy(collision.gameObject);
    }
}
