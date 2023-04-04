//Code followed and referenced from youtube tutorial series https://www.youtube.com/watch?v=aHGlLxh6a88&list=RDCMUCG8bDPqp3jykCGbx-CiL7VQ&index=9
//Additional tutorial https://www.youtube.com/watch?v=A5YSbgqr3sc
using UnityEngine;

public class Background : MonoBehaviour
{

    [Range(-1f, 1f)]
    public float scrollSpeed = 0.5f;
    private float offset;
    private Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    
    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
