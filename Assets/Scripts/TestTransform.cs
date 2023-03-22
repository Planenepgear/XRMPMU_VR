using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode.Components;
[DisallowMultipleComponent]
public class TestTransform : NetworkTransform
{
    protected override bool OnIsServerAuthoritative()
    {
        return false;
    }
}
