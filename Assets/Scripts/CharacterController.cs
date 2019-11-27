using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject[] cloths;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetCloth(int c)
    {
        foreach (var cloth in cloths)
        {
            cloth.SetActive(false);
        }
        cloths[c].SetActive(true);
    }

    public void ChangeAnimation()
    {
        _animator.SetTrigger("change");
    }
}
