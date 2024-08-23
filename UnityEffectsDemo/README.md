# UnityEffectsDemo
A sample setup for incorporating the Xrpa effects system into Unity.

## Getting Started
After initially cloning the repo, you will need to initialize it by running `yarn` in the repo root. You will need to do this any time you pull latest changes (technically, only if the core xrpa libraries change, but it is not harmful to run it every update). See [this link](https://yarnpkg.com/getting-started/install) for Yarn installation instructions.

## Creating/Modifying Effects
Effects define a signal processing graph in TypeScript, with optional parameters that get exposed to Unity. Effects can output to multiple devices. The effects are located in `js/effects/`, and if you add a new one you just need to make sure to also expose it in `js/effects/index.ts`. Whenever you make a change to effects you will need to run `yarn update` in the repo root; this will run the code generator which converts from the TypeScript code to C# MonoBehaviours.

## Using Effects
Each effect creates a MonoBehaviour script component that you can place in your scenes. These components have parameters exposed that get routed to the signal processor. You can run an effect in several ways:
1. Check the `AutoRun` option on the script component. This will make it run the effect when the component's game object becomes alive.
2. Call the `Run()` and `Stop()` methods on the script component.
3. Spawn separate effect instances by calling the `Spawn()` method on the script component. This will create a separate object that you need to manage yourself (it is an IDisposable so you can dispose of it that way, or call `Terminate()` on it). The effect instance will get initialized with the parameter values that are currently set on the script component, but you can modify them separately afterward by calling the accessors on the effect instance object.

## At Runtime
In order for effects to play, you need to have the SignalProcessing module and the SignalOutput module running. From a PowerShell prompt, simply navigate to the root directory and run `yarn SignalOutput` and `yarn SignalProcessing` (in separate PowerShell windows). To exit those modules, just press the enter key with the window in focus.

## Output Devices
### HDK-1
Run `yarn SignalOutput` and in your effect target the device with `strContains("HDK-1")`. SignalOutput will print out what devices it found and what COM port they are on.

### Audio
Target your audio device with `strContains` and the system name of your audio device. SignalOutput will print out a list of devices it finds.
