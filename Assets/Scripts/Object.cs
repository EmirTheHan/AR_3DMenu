using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Object : MonoBehaviour
{
    public string[] foodNames;
    public TextMeshProUGUI foodName;
    public GameObject[] foodModels;
    public GameObject preVisualPlate;
    ARPlaneManager planeManager;
    ARPlane detectedPlane;

    //private void Start()
    //{
    //    planeManager = GetComponent<ARPlaneManager>();
    //}
    //private void FixedUpdate()
    //{
    //    if (detectedPlane != null && preVisualPlate.activeSelf)
    //    {
    //        Vector3 placementPosition = detectedPlane.center;
    //        preVisualPlate.transform.position = placementPosition;
    //    }
    //}
    //void OnEnable()
    //{
    //    planeManager.planesChanged += OnPlanesChanged;
    //}

    //void OnDisable()
    //{
    //    planeManager.planesChanged -= OnPlanesChanged;
    //}

    //void OnPlanesChanged(ARPlanesChangedEventArgs args)
    //{
    //    // Ýlk tespit edilen düzlemi kaydet
    //    if (detectedPlane == null && args.added.Count > 0)
    //    {
    //        detectedPlane = args.added[0];
    //    }
    //}

    public void PlaceFoodModel(int index)
    {
        //if (detectedPlane != null)
        //{
        //    Vector3 placementPosition = detectedPlane.center;
        //    foreach (var item in foodModels)
        //    {
        //        item.SetActive(false);
        //    }
        //    foodModels[index].transform.position = placementPosition;
        //    foodModels[index].SetActive(true);
        //}
        //preVisualPlate.SetActive(false);

        foreach (var item in foodModels)
        {
            item.SetActive(false);
        }
        foodModels[index].SetActive(true);
        foodName.text = foodNames[index];
    }
}