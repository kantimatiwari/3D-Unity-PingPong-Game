
<div align="center">
  <img src="https://i.giphy.com/media/v1.Y2lkPTc5MGI3NjExYm5vaHRnaGpjbXl0M2V2ZGo4Y3E3ZDlua2tmaDZidHVyNTdyazY0NiZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9cw/KzJkzjggfGN5Py6nkT/giphy.gif" width="200"/>
</div>

<h1 align="center">
  <span class="bold">Welcome aboard! Explore our realm</span>
  <img src="https://media.giphy.com/media/WUlplcMpOCEmTGBtBW/giphy.gif" width="40px"/>
</h1>

<div id="badges" align="center">
  <a href="https://www.linkedin.com/in/kantima-tiwari">
    <img src="https://img.shields.io/badge/LinkedIn-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white" alt="LinkedIn Badge" style="border-radius: 5px;"/>
  </a>
  <a href="https://www.instagram.com/_t_t_2003/" target="_blank">
    <img src="https://img.shields.io/badge/Instagram-AA336A?style=for-the-badge&logo=instagram&logoColor=white" alt="Instagram Badge" style="margin-bottom: 5px;" />
  </a>
  <a href="https://github.com/kantimatiwari">
    <img src="https://img.shields.io/badge/GitHub-purple?style=for-the-badge&logo=github&logoColor=white" alt="GitHub Badge"/>
  </a>
</div>


# Cyberpong 3D Game Repository - Beginner Guide

Welcome to the *Cyberpong 3D Game* repository! This project will guide you through creating a 3D Pong-inspired game using Unity, with a futuristic, cyberpunk aesthetic. By following the steps in this repository, you will learn how to set up a new Unity project, design the game world, program player and ball movements, implement AI-controlled opponents, create a scoring system, and add visual effects and audio.

This repository contains all the scripts, assets, and resources you need to build *Cyberpong* from scratch. It is designed for beginners, walking you through each major step in the process.

---

## Key Sections

### 1. **Setting up the Unity Project**

1. **Create a New Unity Project**
   - Open Unity Hub and click **New Project**.
   - Select the **"Universal Render Pipeline"** template to ensure your game uses advanced graphics features.
   - Name your project `Cyberpong` and select a location to save it. Then click **Create**.

2. **Familiarizing with Unity Interface**
   - After your project is created, you'll be introduced to the Unity interface, including the **Scene View**, **Hierarchy**, **Project Panel**, and **Inspector**.
   - These panels will help you organize your game objects, manage assets, and write scripts. Take some time to familiarize yourself with these components, as you'll be using them throughout the project.

---

### 2. **Designing the Game World**

1. **Clean Up the Project**
   - Begin by removing the default example assets provided by Unity. This will clear your workspace and allow you to start fresh with your own assets.

2. **Designing the *Cyberpong* Arena**
   - The game’s environment is simple but engaging. You’ll create an arena with two paddles (one for the player and one for the AI), as well as a ball that bounces around.
   - Import the pre-made 3D models for the arena, rackets, and ball into your Unity project. These assets will serve as the basic visual components of the game.
   - You can add these assets by dragging and dropping the models from the **Assets** folder into the **Scene**.

---

### 3. **Implementing Player Controls**

1. **Place the Arena, Paddles, and Ball**
   - Drag the arena, player paddles, and ball into your scene. Arrange them so the ball is centered in the middle of the arena, with the paddles on either side.
   - Ensure that the paddles are positioned in such a way that they can interact with the ball as it moves across the screen.

2. **Adjust the Camera**
   - Adjust the camera to provide a top-down view of the game. This view is crucial for giving the player an overview of the entire arena and making it easier to control the paddles.

3. **Customize the Ball’s Appearance**
   - Apply a custom material to the ball to give it a unique visual style. Consider using a glowing, futuristic material to enhance the cyberpunk aesthetic.

---

### 4. **Programming the Ball's Movement**

1. **Make the Ball a Kinematic Rigidbody**
   - Add a **Rigidbody** component to the ball and set it to **Kinematic**. This allows the ball to interact with physics for collision detection, but you’ll manually control its movement through scripts.

2. **Implement Ball Movement**
   - Write a script that allows you to control the ball’s movement manually. You’ll update the ball’s position based on input or AI-controlled behavior.

3. **Collision Detection**
   - Implement collision detection between the ball and the player paddles, as well as the walls of the arena. When the ball collides with these objects, its direction will change accordingly.

4. **Add Randomness to Ball's Initial Direction**
   - To make the gameplay more dynamic, add a small amount of randomness to the ball's initial direction each time the game starts or a point is scored.

---

### 5. **Introducing an AI-Controlled Opponent**

1. **Toggle Between Human and AI Opponent**
   - Implement a feature that lets players toggle between a human opponent (controlled by player input) and an AI-controlled opponent. This can be done using a simple UI button or keyboard input.

2. **Program the AI's Behavior**
   - Write a script to control the AI. The AI should track the ball’s position on the z-axis and move accordingly to "bounce" the ball back.
   - While the AI will start with simple behavior (following the ball), you can later improve it by adding predictive movement or difficulty scaling.

---

### 6. **Scoring and Game Reset**

1. **Create Goal Detection Areas**
   - Add invisible goal areas on the left and right sides of the arena. These areas will detect when the ball crosses the boundary, signifying a point has been scored.

2. **Develop the Goal Controller Script**
   - Create a **Goal Controller** script that listens for ball collisions with the goal areas. When a goal is scored, the script triggers the **Game Controller**, which handles the game’s overall logic.

3. **Reset Ball and Start New Round**
   - After a point is scored, reset the ball’s position to its starting point and implement a brief countdown timer before the next round begins. This ensures smooth game flow between rounds.

---

### 7. **Adding Visual Effects and Audio**

1. **Enhance Visuals with Effects**
   - Add particle effects, such as smoke, to the player rackets to create a sleek, cyberpunk style. 
   - Add spark effects when the ball collides with the rackets or walls to make the interactions feel more dynamic and impactful.

2. **Add Background Music**
   - Use an **AudioSource** component to add background music to the game. Choose a track that fits the cyberpunk theme and adds energy to the game’s atmosphere.

3. **Sound Effects**
   - Add sound effects for key interactions, like ball hits, goals, and paddle movement. These sounds help create a more immersive experience.

---

## Conclusion

By the end of this repository, you will have successfully created a *Cyberpong* 3D game featuring a fully functional player, AI opponent, scoring system, and various visual and audio effects. 

Feel free to experiment with the code and assets to make the game your own! You can improve the AI, add new features, or refine the visual effects. This project serves as a great introduction to Unity, 3D game mechanics, and interactive design.

### Next Steps
- **Refine AI**: Experiment with more advanced AI behaviors, like predictive movement or difficulty scaling.
- **Add New Features**: Add power-ups, new arenas, or more advanced player controls.
- **Improve Visuals**: Use shaders, advanced particle effects, or different textures to enhance the game’s appearance.

Thank you for checking out the *Cyberpong* repository. Happy coding!
