using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialBlock : MonoBehaviour
{
    //ÖZET
    //10 küremiz var ve örneðin KüreMat adýnda da 1 materyalimiz var.
    //Bu küremizin bazýlarýnýn rengini deðiþtirmek istiyoruz yani materyalini.
    // Color ile deðiþtirince unity arka planda otomatik yeni material oluþturup atar.
    //Bunun yerine shader da [PerRendererData] ekleyerek arkada KüreMat için veride tutmasýný saðlýyoruz.
    //Bu sayede rengi deðiþtirirken yeni material oluþturmak yerine mevcutu tutup deðiþtiriyor.
    //Kýsaca yeni materyal oluþturmasýný engelliyoruz.

    public Color color;
    Renderer renderer;
    MaterialPropertyBlock propertyBlock;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        propertyBlock = new MaterialPropertyBlock();
    }
    void Update()
    {
        propertyBlock.SetColor("_Color", color);
        renderer.SetPropertyBlock(propertyBlock);
    }
}
