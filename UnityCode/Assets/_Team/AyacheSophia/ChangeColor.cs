using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    public Color current;
    public Color colorCube;
    public Camera cam;
    public List<Color> colors;
    public Renderer cube;

    // Use this for initialization
    void Start()
    {
        cam = GetComponent<Camera>();
        colors = FillTabColor();
        //current = RndColor();
        //wanted = RndColor();
    }

    // Update is called once per frame
    void Update()
    {
        current = Color.Lerp(RndColor(), RndColor(), Time.deltaTime*8);
        cam.backgroundColor = current;
        colorCube = Color.Lerp(RndColor(), RndColor(), Time.deltaTime * 5);
        //cube
    }


    private List<Color> FillTabColor()
    {
        List<Color> listColors = new List<Color>();
        listColors.Add(Color.blue);
        listColors.Add(Color.cyan);
        listColors.Add(Color.green);
        listColors.Add(Color.magenta);
        listColors.Add(Color.red);
        listColors.Add(Color.yellow);
        listColors.Add(Color.white);
        listColors.Add(Color.grey);
        listColors.Add(Color.black);

        return listColors;
    }

    private Color RndColor()
    {
        Color c = new Color();
        System.Random rnd = new System.Random();
        int nbr = rnd.Next(0, colors.Count);
        c = colors[nbr];

        return c;
    }
}
