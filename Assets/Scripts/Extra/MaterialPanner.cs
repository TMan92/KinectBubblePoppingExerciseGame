//Code followed and obtained from youtube tutorial series https://www.youtube.com/watch?v=aHGlLxh6a88&list=RDCMUCG8bDPqp3jykCGbx-CiL7VQ&index=9
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialPanner : MonoBehaviour
{
    private MeshRenderer mMeshRenderer = null;
    private Vector2 mOffset = Vector2.zero;

    void Awake()
    {
        mMeshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        mOffset.x += 0.075f * Time.deltaTime;
        mMeshRenderer.material.SetTextureOffset("_MainTex", mOffset);
    }
}
