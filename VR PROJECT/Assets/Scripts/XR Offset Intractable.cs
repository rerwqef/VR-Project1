using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XROffsetIntractable : XRGrabInteractable
{
    // Start is called before the first frame update
    void Start()
    {
        if (!attachTransform)
        {
            GameObject attachPiont = new GameObject("Offset Grab pivot");
            attachPiont.transform.SetParent( transform,false);
            attachTransform=attachPiont.transform;
        }
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        attachTransform.position=args.interactorObject.transform.position;
        attachTransform.rotation=args.interactorObject.transform.rotation;
        base.OnSelectEntered(args);
    }
}
