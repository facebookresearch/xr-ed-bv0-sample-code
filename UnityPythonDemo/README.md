# UnityPythonDemo

This repository demonstrates the ability for Xrpa to allow a Python application to control behavior inside of a Unity project, and to transmit and display image data from Python to Unity.

To run the Python code, from the `python/` directory run the following:

`conda env create -f environment.yaml` (one-time)

`conda activate unity-python-demo` (once per PowerShell instance)

`python main.py`

Open the Unity project located in the `unity/` directory and run the game with the default scene.

This will run a Python-based UI where you can spawn Stimulus objects in Unity. With the Unity game window focused, press the "a" key on your keyboard to send the user response event back to the Python application, which will then despawn the Stimulus objects.

In addition, it creates a PsychoPy window whose visuals are reflected into a Unity texture, applied to a quad in the scene.

If you would like to modify the schema used for the Stimulus object (including adding fields to the user response event), open the `xrpa_setup/` directory in PowerShell and run:
`yarn` (one time, to install node module dependencies)

`yarn build` (each time you change the schema)

This process will regenerate the Python and C# code needed for intercommunication.
