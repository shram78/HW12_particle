using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Movable : MonoBehaviour
{
    [SerializeField] ParticleSystem _particleSystem;

    private Animator _animator;
    private const string _buttonPressed = "isButtonPressed";

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetBool(_buttonPressed, false);

        if (Input.GetKey(KeyCode.Space))
        {
            _animator.SetBool(_buttonPressed, true);
            _particleSystem.Play();
        }
    }
}