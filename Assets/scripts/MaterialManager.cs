using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class MaterialManager : MonoBehaviour
{

    public string inputImageDirectoryPath = "";
    public GameObject[] surfaces;
    public Material[] materials;
    public Texture[] textures;
    public TextMeshPro[] surfaceInfoTextArray;
    public Button testButton;

    private bool surfacesVisible = false;

    void Awake()
    {


        
        materials = new Material[surfaces.Length];
        textures = new Texture[surfaces.Length];
        surfaceInfoTextArray = new TextMeshPro[surfaces.Length];

        for(int i=0; i<surfaces.Length; i++){
            materials[i] = surfaces[i].GetComponent<MeshRenderer>().material;
            surfaceInfoTextArray[i] = surfaces[i].transform.GetChild(0).GetComponent<TextMeshPro>();
            Debug.Log(surfaces[i].name + ":: " + surfaces[i].transform.GetChild(0).name);
            surfaces[i].SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        testButton.onClick.AddListener(ToggleSurfaceVisibility);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleSurfaceVisibility()
    {
        surfacesVisible = !surfacesVisible;

        for(int i=0; i<surfaces.Length; i++)
            surfaces[i].SetActive(surfacesVisible);

    }
}
