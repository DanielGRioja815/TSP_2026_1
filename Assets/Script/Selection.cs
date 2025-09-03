using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Selection : MonoBehaviour
{
    public Material InactiveMaterial;
    public Material GazedMaterial;

    private Renderer MyRender;

    public static bool gazedAt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InactiveMaterial = this.gameObject.GetComponent<Material>();
        gazedAt = false;
    }

    //Metodo para Marcar Seleccion
    public void OnPointerEnder()
    {
        gazedAt=true;
        SetMaterial(gazedAt);
    }

    //Metodo para desmarcar seleccion 
    public void OnPointerExit()
    {
        gazedAt = false;
        SetMaterial(gazedAt);
    }

    //Cambio de material
    private void SetMaterial(bool gazedAt)
    {
        if (InactiveMaterial != null && GazedMaterial != null)
        {
            MyRender.material = gazedAt ? GazedMaterial : InactiveMaterial;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
