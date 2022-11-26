using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgColorController : MonoBehaviour
{
    private Camera main_camera;

    public Color[] colors;
    public int color_change_duration = 5;
    //private Color new_color;

    private void Awake()
    {
        main_camera = GetComponent<Camera>();
        //new_color = colors[0];
    }

    private void Start()
    {
        StartCoroutine(ChangeColorOverTime());
    }

    private void FixedUpdate()
    {

    }

    private IEnumerator ChangeColorOverTime ()
    {
        while (true)
        {
            ChangeColor();
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void ChangeColor()
    {
        Color cam_color = main_camera.backgroundColor;
        int color_index = Random.Range(0, colors.Length);
        main_camera.backgroundColor = Color.Lerp(cam_color, colors[color_index], 1f);
        //new_color = cam_color;
    }
}
