using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGlowColour : MonoBehaviour
{


    public Texture enterMaterial;
    public Texture exitMaterial;
    

    public void ChangeEnter()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.mainTexture = this.enterMaterial;
    }

    public void ChangeExit()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.mainTexture = this.exitMaterial;
    }
}
