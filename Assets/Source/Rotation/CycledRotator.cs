using DG.Tweening;
using UnityEngine;

public class CycledRotator : MonoBehaviour
{
    private const float RotationCycleDuration = 6f;
    private readonly Vector3 rotationEndAngles = new Vector3(0, 360, 360);

    private void Start()
    {
        transform.DORotate(rotationEndAngles, RotationCycleDuration / 2f, RotateMode.FastBeyond360)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Restart);
    }
}
