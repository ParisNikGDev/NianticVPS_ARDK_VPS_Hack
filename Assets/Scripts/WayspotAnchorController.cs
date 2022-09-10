using System.Collections.Generic;
using System.Linq;
using System;

using UnityEngine;

using Niantic.ARDK.AR;
using Niantic.ARDK.Utilities.Input.Legacy;
using Niantic.ARDK.AR.HitTest;
using Niantic.ARDK.Extensions;
using Niantic.ARDK.AR.WayspotAnchors;
using Niantic.ARDK.LocationService;
using Niantic.ARDK.AR.ARSessionEventArgs;
using Niantic.ARDK.AR.Configuration;
using Niantic.ARDK.Utilities;
using UnityEngine.UI;

public class WayspotAnchorController : MonoBehaviour
{
    /*
     * Global variables
     * These sets of variables are used either to display content on the screen,
     * or for accessing ARDK features across methods.
     */
    
    public Camera _camera; // the ARDK's AR camera instead of the default Unity camera
    public GameObject _objectPrefab; // the prefab we will be spawning on screen
    public Text _statusLog; // updates the status log for Wayspot Anchors on screen
    public Text _localizationStatus; // updates the localization status message on screen
    
    private string LocalSaveKey = "my_wayspots"; // key used to store anchors locally
    private IARSession _arSession; // the AR session started by ARDK
    private WayspotAnchorService _wayspotAnchorService; // controls VPS features used

    /* 
     * Unity Event Lifecycle Functions
     * Learn more: https://docs.unity3d.com/Manual/ExecutionOrder.html
     */

    // When our app is enabled, register the OnSessionInitiliazed method to
    // ARDK's SessionInialized event handler
    private void OnEnable()
    {
     
    }
    
    // Listen for touch events only if the app has localized to a VPS Wayspot
    void Update()
    {

    }

    // Deregister the SessionInitiliazed method to ensure AR Session is terminated between sessions
    private void OnDisable()
    {

    }

    /*
     * Wayspot Anchor methods
     * The following methods allow us to place anchors with our game objects attached to them
     */

    // Place the Wayspot Anchor into the scene based on touch
    private void PlaceAnchor(Matrix4x4 poseData)
    {
        
    }

    // Create and attach the game object prefab to the wayspot anchor
    private void CreateWayspotAnchorGameObject(IWayspotAnchor anchor, Vector3 position,Quaternion rotation)
    {
     
    }

    /* 
     * ARDK Event Handlers
     * 
     */

    // Initialize the AR Session
    void OnSessionInitialized(AnyARSessionInitializedArgs args)
    {

    }

    // Once the session has run, we will need to create the wayspot anchor service
    void OnSessionRan(ARSessionRanArgs args)
    {

    }

    // Process the touch to see if it falls on a horizontal plane
    private void OnTouchScreen(Touch touch)
    {

    }

    /*
     * Button Handlers
     * The UI buttons on screen are hooked up to the following button handlers.
     */

    // Gather all of the wayspot anchors and save them on device
    public void SaveLocalWayspotAnchors()
    {

    }

    // Using the player key, check if there are stored wayspot anchors on device. Restore them if true.
    public void LoadLocalWayspotAnchors()
    {
        
    }

    // Stretch goal: Clear local Wayspot Anchor cache
    public void ClearLocalWasyspotAnchors()
    {
        
    }

    // Stretch goal: Restart wayspot anchor service
    public void RestartWayspotAnchorService()
    {
     
    }

    /*
     * Serializabe Data Class 
     * Used for storing Wayspot Anchor Payloads
     */

    [Serializable]
    private class MyStoredAnchorsData
    {
        public string[] Payloads = Array.Empty<string>();
    }
}