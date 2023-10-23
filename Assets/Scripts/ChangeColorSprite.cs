using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeColorSprite : MonoBehaviour
{
    public float darkenFactor = 0.5f;
    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    public SpriteRenderer spriteWith;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
        spriteWith.enabled = false;
    }

    public void Darken()
    {
        if (spriteRenderer != null && darkenFactor >= 0.0f)
        {
            Color currentColor = spriteRenderer.color;
            Color newColor = new Color(
                currentColor.r * darkenFactor,
                currentColor.g * darkenFactor,
                currentColor.b * darkenFactor
            );
            spriteRenderer.color = newColor;
        }
    }

    public void Lighten()
    {
        spriteWith.enabled = true;
    }

    public void Normal()
    {
        spriteWith.enabled = false;
        spriteRenderer.color = originalColor;
    }
}


