# Unity-echo3D-Demo-AsteroidAmbush
Save the galaxy! Hit the 3 asteroids to save the galaxy! If you hit the planets, the game will restart. Control rocket with your mouse click.

## Setup
* Don't have an echo3D API key? Make sure to register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).

* [Add the Unity SDK](https://medium.com/r/?url=https%3A%2F%2Fdocs.echo3d.co%2Funity%2Finstallation). Troubleshoot [here](https://docs.echo3d.com/unity/troubleshooting#im-getting-a-newtonsoft.json.dll-error-in-unity). _(Note: The echo3D Unity SDK is supported in 2020.3.25 and higher.)_

* Clone this repo.


## Steps
* [Add these models](https://docs.echo3D.co/quickstart/add-a-3d-model) to the echo3D console from the Unity Assets/Models folder:  <br>
      - Planet 1 <br>
      - Planet 2 <br>
      - Planet 3 <br>
      - Astroid 1 <br>
      - Astroid 2 <br>
      - Astroid 3 <br>

* Open the _SampleScene_ scene in Unity.

* [Set the API key](https://docs.echo3d.co/quickstart/access-the-console) and Entry IDs for those same models. <br>
![APIKeyandEntryId](https://user-images.githubusercontent.com/99516371/195749269-f7a43477-b67a-49e8-a212-6abdb9c948fd.png)<br>
![NEWAPIKeyandEntryID](https://user-images.githubusercontent.com/99516371/205407613-b746840f-8e8a-4ec8-b056-a680395dfab4.png)<br>

* [Type your Secret Key](https://docs.echo3d.co/web-console/deliver-pages/security-page#secret-key) as the value for the parameter secKey in the file Packages/co.echo3D.unity/Runtime/Echo3DHologram.cs. _(Note: Secret Key only matters if you have the Security Key enabled). You can turn it off in the Security options in your echo3D console._
![NEWSecKey2](https://user-images.githubusercontent.com/99516371/195749308-b2349a3b-7e43-4d3c-8f09-fbfa9d3cb0be.png)<br>


* (Recommended) To move, resize or edit the assets live in your Scene view, check the boxes for “Editor Preview” and “Ignore Model Transforms”. To enable this, click Echo3D > Load Editor Holograms in your Unity toolbar. <br>
![EditorPreviewAndIgnoreModelTransforms](https://user-images.githubusercontent.com/99516371/195749348-dc0b06ad-efa6-4dbd-962f-0119b5c33ea0.png)<br>
![LoadHolograms](https://user-images.githubusercontent.com/99516371/195749354-b2295183-f877-444a-af22-ed87ffb17705.png) <br>



## Run
Press Play in Unity and click in the Game window to change the rocket's direction. Hit the 3 asteroids to save the galaxy! If you hit the planets, the game will restart.

## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 

## Sources
* Space assets: [jcomp / freepik](https://www.freepik.com/free-vector/spacecraft-shuttle-exploration-fly-outer-space-vehicle-machine-astronomy-station-vector-illustration_25273368.htm#query=rocket%20ship%20and%20planets&position=1&from_view=search)

## Screenshots
![GIF](https://user-images.githubusercontent.com/99516371/175661388-b13bb532-e758-405f-9048-20dd6b9bfeee.gif)

![Screenshot2](https://user-images.githubusercontent.com/99516371/175661372-eb94504a-83b8-4d5b-9656-ff65811df883.png)
![Screenshot3](https://user-images.githubusercontent.com/99516371/175661376-363db3ea-3762-46b6-9df5-dd7385a86e9c.png)
![Screenshot1](https://user-images.githubusercontent.com/99516371/175661379-24721554-3686-4807-8096-d8f823c61bfc.png)

