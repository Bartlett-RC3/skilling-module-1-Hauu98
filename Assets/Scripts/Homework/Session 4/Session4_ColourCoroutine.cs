using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_ColourCoroutine : MonoBehaviour
{
    public float fadeInTime = 5f;
    public float fadeOutTime = 8f;
    public float fadeDelay = 1f;
    public Color startColor;
    public Color endColor;

    public SpriteRenderer _spriteRender;

    private void Awake()
    {
        _spriteRender = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(colourLerpIn());
    }

    IEnumerator colourLerpIn()
    {
        for (float t = 0.01f; t<fadeInTime; t+=0.1f)
        {
            _spriteRender.material.color = Color.Lerp(startColor, endColor, t / fadeInTime);
            yield return null;
        }
        yield return new WaitForSeconds(fadeDelay);
        StartCoroutine(colorLerpOut());
    }

    IEnumerator colorLerpOut()
    {
        for (float t = 0.01f; t < fadeOutTime; t += 0.1f)
        {
            _spriteRender.material.color = Color.Lerp(endColor, startColor, t / fadeOutTime);
            yield return null;
        }
    }
}
