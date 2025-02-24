using UnityEngine;

public class ConditionalPractice : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;
    public Color go2elsecolor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ColorGameObjectByName();
        ColorGameObjectByTag();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ColorGameObjectByName()
    {
        Debug.Log("go is named " + go.name);
        Debug.Log("go2 is named " + go2.name);

        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();

        if (go.name == "Cube")
        {
            //change the color to magenta
            goMeshRenderer.material.color = Color.magenta;
        }
        else if(go.name == "Sphere")
        {
            //change the color to cyan
            goMeshRenderer.material.color = Color.cyan;

        }
        else if (go.name == "Cylinder")
        {
            //change the color to black
            goMeshRenderer.material.color = Color.black;
        }
        else
        {
            //change the color to orange
            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
        }

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.name == "Cube")
        {
            //change the color to gray
            go2MeshRenderer.material.color = Color.gray;
        }
        else if (go2.name == "Sphere")
        {
            //change the color to white
            go2MeshRenderer.material.color = Color.white;
        }
        else if (go2.name == "Cylinder")
        {
            //change the color to red
            go2MeshRenderer.material.color = Color.red;
        }
        else
        {
            //change the color to orange
            go2MeshRenderer.material.color = go2elsecolor;
        }
    }
    void ColorGameObjectByTag()
    {
        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();

        if (go.tag == "CoolGuy")
        {
            //change the color to magenta
            goMeshRenderer.material.color = Color.magenta;
        }
        else if (go.tag == "NotCoolGuy")
        {
            //change the color to cyan
            goMeshRenderer.material.color = Color.cyan;

        }
        else if (go.tag == "OkayGuy")
        {
            //change the color to black
            goMeshRenderer.material.color = Color.black;
        }
        else
        {
            //change the color to orange
            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
        }

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.tag == "CoolGuy")
        {
            //change the color to gray
            go2MeshRenderer.material.color = Color.gray;
        }
        else if (go2.tag == "NotCoolGuy")
        {
            //change the color to white
            go2MeshRenderer.material.color = Color.white;
        }
        else if (go2.tag == "OkayGuy")
        {
            //change the color to red
            go2MeshRenderer.material.color = Color.red;
        }
        else
        {
            //change the color to orange
            go2MeshRenderer.material.color = go2elsecolor;
        }
    }
}
