using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Color[] _colors;

    private int _currentColorIndex;

    private void Start()
    {
        _currentColorIndex = 0;
        UpdateColor();
    }

    private void OnMouseDown()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        _currentColorIndex++;

        if (_currentColorIndex >= _colors.Length)
        {
            _currentColorIndex = 0;
        }

        UpdateColor();
    }

    private void UpdateColor()
    {
        _material.color = _colors[_currentColorIndex];
    }
}
