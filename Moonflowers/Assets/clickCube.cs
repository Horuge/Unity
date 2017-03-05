using UnityEngine;

public class clickCube : MonoBehaviour {

    public Material ColorMaterial;
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
       ColorMaterial = GetComponent<Renderer>().material; // Carga el material.
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseUp()
    {
        ColorMaterial.color = Color.green; // Cambia color a verde.
        rb.useGravity = true;              // Activa gravedad.
    }
}