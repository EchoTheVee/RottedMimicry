using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropHighlight : MonoBehaviour
{
    public Color highlight_color;
    public bool is_highlighted = false;
    private Material material;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    public void setHighlight(bool set_highlight)
    {
        is_highlighted = set_highlight;

        if (!set_highlight) material.color = Color.white;
    }

    void Update()
    {
        if (is_highlighted)
        {
            var ratio = Mathf.Abs(Mathf.Sin(Time.time * 4f));
            material.color = Color.Lerp(Color.white, highlight_color, ratio);
        }
    }
}
