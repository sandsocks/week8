using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI tankPosition, fuelPositionText;
    public ObjectManager fuelPosition;
    public GameObject tank, fuel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        //tankPosition.text = tank.transform.position + "";
        //fuelPosition.text = fuel.transform.position + "";
        fuelPositionText.text = fuelPosition.fuelPos + "";
        fuelPosition = fuel.GetComponent<ObjectManager>();
    }

    // Update is called once per frame
    void Update()
    {
        tankPosition.text = tank.transform.position + "";
        //fuelPosition.text = fuel.transform.position + "";
    }
}
