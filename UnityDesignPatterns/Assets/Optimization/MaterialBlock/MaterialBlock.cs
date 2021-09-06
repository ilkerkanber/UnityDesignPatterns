using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialBlock : MonoBehaviour
{
    //�ZET
    //10 k�remiz var ve �rne�in K�reMat ad�nda da 1 materyalimiz var.
    //Bu k�remizin baz�lar�n�n rengini de�i�tirmek istiyoruz yani materyalini.
    // Color ile de�i�tirince unity arka planda otomatik yeni material olu�turup atar.
    //Bunun yerine shader da [PerRendererData] ekleyerek arkada K�reMat i�in veride tutmas�n� sa�l�yoruz.
    //Bu sayede rengi de�i�tirirken yeni material olu�turmak yerine mevcutu tutup de�i�tiriyor.
    //K�saca yeni materyal olu�turmas�n� engelliyoruz.

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
