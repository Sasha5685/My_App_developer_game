using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingSettingOption : MonoBehaviour
{
    public GameObject VariantCreateGameObject;
    public GameObject QutVariantCreateGameObject;
    public CreatingGameSistem creatingGameSistem;

    public void OpenVariantCreate()
    {
        VariantCreateOpen();
    }
    public void QutVariantCreate()
    { 
        QutVariantCreateGameObject.SetActive(false);
    }
    public void VariantCreateOpen()
    {
        if(creatingGameSistem.IsCreate == false)
        {
            VariantCreateGameObject.SetActive(true);
            QutVariantCreateGameObject.SetActive(true);
        }
    }


}
