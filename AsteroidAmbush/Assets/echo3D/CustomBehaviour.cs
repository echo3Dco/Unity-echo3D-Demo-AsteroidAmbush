/**************************************************************************
* Copyright (C) echoAR, Inc. (dba "echo3D") 2018-2021.                    *
* echoAR, Inc. proprietary and confidential.                              *
*                                                                         *
* Use subject to the terms of the Terms of Service available at           *
* https://www.echo3D.co/terms, or another agreement                       *
* between echoAR, Inc. and you, your company or other organization.       *
***************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;

    // Add field to change Shader to remove Sprite backgrounds (Sprites-Default)
    public Shader defaultSpriteShader;


    /// <summary>
    /// EXAMPLE BEHAVIOUR
    /// Queries the database and names the object based on the result.
    /// </summary>

    // Use this for initialization
    void Start()
    {
        // Add RemoteTransformations script to object and set its entry
        this.gameObject.AddComponent<RemoteTransformations>().entry = entry;


        // Qurey additional data to get the name
        string value = "";
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out value))
        {
            // Set name
            this.gameObject.name = value;
        }

        Invoke("ChangeShader", 15.0f);

    }

    void ChangeShader()
    {
        // Changes defaultSpriteShader from Standard shader to the one chosen in Inspector
        MeshRenderer myRenderer = GetComponentInChildren<MeshRenderer>();
        if (myRenderer)
        {
            myRenderer.material.shader = defaultSpriteShader;
            Debug.Log(defaultSpriteShader == null);
        }
        else
        {
            Debug.Log("No mesh renderer detected");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}