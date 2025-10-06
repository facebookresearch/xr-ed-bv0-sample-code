## How it works

This demo was built using [Xrpa](https://github.com/facebookexperimental/xrpa).

 [Xrpa](https://github.com/facebookexperimental/xrpa) is a general-purpose framework for generating runtime-usable components from code written in C++ or Python. The resulting code is then utilized by external host environments like Unity or Unreal Engine.

[Xrpa](https://github.com/facebookexperimental/xrpa) works by building external binaries that then communciate with Unity via shared memory. Each Xrpa module requires an external processes to be running in order to facilitate the communication of external libraries and the Unity runtime. Adding dependencies to your package.json file will pull new binaries into your project, and you can find them in node_modules/@xrpa.
