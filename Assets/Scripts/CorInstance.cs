using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialPropretyBlock : MonoBehaviour
{
    [ColorUsage(true, true)]
    public Color PropColor = Color.white;
    private ParticleSystemRenderer rend;
    private MaterialPropertyBlock propBlock;
    void Awake()
    {
        rend = GetComponent<ParticleSystemRenderer>();
        propBlock = new MaterialPropertyBlock();

        rend.GetPropertyBlock(propBlock);
        propBlock.SetColor("_BaseColor", PropColor);
        rend.SetPropertyBlock(propBlock);
    }
    void OnValidate()
    {
        if (rend == null)
            rend = GetComponent<ParticleSystemRenderer>();
        if (propBlock == null)
            propBlock = new MaterialPropertyBlock();
        rend.GetPropertyBlock(propBlock);
        propBlock.SetColor("_BaseColor", PropColor);
        rend.SetPropertyBlock(propBlock);
    }   
}
