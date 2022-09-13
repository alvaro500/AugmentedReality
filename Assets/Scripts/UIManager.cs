using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject itemsMenuCanvas;
    [SerializeField] private GameObject ARPositionCanvas;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.onMainMenu += ActivateMainMenu;
        GameManager.instance.onItemsMenu += ActivateItemsMenu;
        GameManager.instance.onARPosition += ActivateARPosition;
    }

    private void ActivateMainMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        //mainMenuCanvas.transform.GetChild(0).transform.localScale = Vector3.one;
        //mainMenuCanvas.transform.GetChild(1).transform.localScale = Vector3.one;
        //mainMenuCanvas.transform.GetChild(2).transform.localScale = Vector3.one;

        //itemsMenuCanvas.transform.GetChild(0).transform.localScale = Vector3.zero;
        //itemsMenuCanvas.transform.GetChild(1).transform.localScale = Vector3.zero;
        //itemsMenuCanvas.transform.GetChild(1).transform.position = new Vector3(itemsMenuCanvas.transform.position.x, 180, itemsMenuCanvas.transform.position.z);

        //ARPositionCanvas.transform.GetChild(0).transform.localScale = Vector3.zero;
        //ARPositionCanvas.transform.GetChild(1).transform.localScale = Vector3.zero;
    }

    private void ActivateItemsMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);

        //mainMenuCanvas.transform.GetChild(0).transform.localScale = Vector3.zero;
        //mainMenuCanvas.transform.GetChild(1).transform.localScale = Vector3.zero;
        //mainMenuCanvas.transform.GetChild(1).transform.localScale = Vector3.zero;

        //itemsMenuCanvas.transform.GetChild(0).transform.localScale = Vector3.one;
        //itemsMenuCanvas.transform.GetChild(1).transform.localScale = Vector3.one;

        //Transform itemsMenuCanvasTransform = itemsMenuCanvas.transform.GetChild(1);
        //itemsMenuCanvasTransform.position = new Vector3 (itemsMenuCanvasTransform.position.x, 300, itemsMenuCanvasTransform.position.z);

    }

    private void ActivateARPosition()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        //mainMenuCanvas.transform.GetChild(0).transform.localScale = Vector3.zero;
        //mainMenuCanvas.transform.GetChild(1).transform.localScale = Vector3.zero;
        //mainMenuCanvas.transform.GetChild(2).transform.localScale = Vector3.zero;

        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        //itemsMenuCanvas.transform.GetChild(0).transform.localScale = Vector3.zero;
        //itemsMenuCanvas.transform.GetChild(1).transform.localScale = Vector3.zero;
        //Transform itemMenuCanvasTransform = itemsMenuCanvas.transform.GetChild(1);
        //itemMenuCanvasTransform.position = new Vector3(itemMenuCanvasTransform.position.x, 180, itemMenuCanvasTransform.position.z);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        //ARPositionCanvas.transform.GetChild(0).transform.localScale = Vector3.one;
        //ARPositionCanvas.transform.GetChild(1).transform.localScale = Vector3.one;
    }
}
