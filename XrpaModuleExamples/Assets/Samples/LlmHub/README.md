# LLMHub Demo

This demo showcases Llama integration with Unity. You can use this sample to add easy LLM integration into your projects.

## Before You Begin

### Step 1: Generate a Llama Developer Key
1. Navigate to [https://llama.developer.meta.com/api-keys/](https://llama.developer.meta.com/api-keys/) to create your developer API key.
2. Within each demo scene, find the GameObject that includes an `apiKey` property.
3. Paste your generated API key into this property.

### Step 2: Start the External Processes
- Find LlmHub.exe (or the corresponding Mac app)
- Double click to run the executable appropriate for your platform (macOS or Windows).
- Monitor the output in your terminal to observe communication between the LLMHub and Unity sample scenes.
- Run the Python MCP server if you want to view the MCP demo scene.

### Step 3: Run the Sample Scenes
- Open any of the provided sample scenes in Unity.
- Make sure you have added your developer key to the `apiKey` property
- Run the scene. Each scene contains an input field; enter your prompt here to interact with the LLM.
- Check the terminal windows running the Python MCP server and LLMHub processes for any errors or debug messages.
