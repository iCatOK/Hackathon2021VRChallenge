using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FlowerColorChanger : MonoBehaviour
{

    List<string> liquids;
    //List<string> neededLiquids;
    public MeshRenderer flowerMesh;
    public Material targetMaterial;
    private Color startColor;
    private Color currentColor;
    private bool isLerping = false;
    public MeshRenderer innerLiquid;
    
    // Start is called before the first frame update
    void Start()
    {
        liquids = new List<string>();
        startColor = flowerMesh.material.color;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AddLiquid(string potionType)
    {
        Debug.LogError("Список " + liquids.Capacity);
        foreach (var elem in liquids) {
            Debug.Log(elem);
        }
        if(!liquids.Contains(potionType))
            liquids.Add(potionType);
        if (liquids.Contains("Ethirium")&&liquids.Contains("Ammiac"))
        {
            ChangeColor();
        }
    }

    public void ChangeColor()
    {
        flowerMesh.material = targetMaterial;
    }
}
