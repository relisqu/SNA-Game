using System;
using DG.Tweening;
using UnityEngine;

public class PulseAnimation : MonoBehaviour
{
    public Vector3 Scale;
    public Vector3 Rotation;

    public float Speed;
    private void OnEnable()
    {
        DOTween.KillAll(transform);
        transform.DOScale(Scale, Speed).SetSpeedBased().SetLoops(-1, LoopType.Yoyo);
        transform.DOPunchRotation(Rotation, Speed,0).SetSpeedBased().SetLoops(-1, LoopType.Yoyo);
    }
}