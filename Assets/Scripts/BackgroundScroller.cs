using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour
{

    public float scrollSpeed;
    private Vector2 savedOffset;
    private MeshRenderer render;

    void Start()
    {
        render = GetComponent<MeshRenderer>();
        savedOffset = render.sharedMaterial.GetTextureOffset("_MainTex");
    }

    void Update()
    {
        float y = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(savedOffset.x, y);
        render.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }

    void OnDisable()
    {
        render.sharedMaterial.SetTextureOffset("_MainTex", savedOffset);
    }
}
