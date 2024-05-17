using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class setPokointraction : MonoBehaviour
{

    public Transform pokoAttachPonit;
    private XRPokeInteractor _xrpokeInterractor;
    // Start is called before the first frame update
    void Start()
    {
        _xrpokeInterractor =FindAnyObjectByType<XRPokeInteractor>();
        SetPokointraction();
    }
    void SetPokointraction()
    {
        if (pokoAttachPonit == null) return;
        if(_xrpokeInterractor==null)return;
        _xrpokeInterractor.attachTransform = pokoAttachPonit;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
