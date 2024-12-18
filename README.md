
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



# Cyberpong 3D Game Tutorial - Beginner Guide

This tutorial will guide you through the process of creating a 3D game from scratch using Unity. Over the course of one hour, you'll learn how to set up a new project, design the game world, program player and ball movements, implement AI-controlled opponents, create a scoring system, and add visual effects and audio. The final result is a fun, cyberpunk-inspired 3D game called *Cyberpong*, which is a modern take on the classic Pong game.

## Key Sections

### 1. **Setting up the Unity Project**
The tutorial starts with setting up a new Unity project. The first step is to create a new Unity project and select the **"Universal Render Pipeline"** template. This template ensures that your game will take advantage of Unity's advanced graphics features, which are essential for creating visually appealing 3D environments and effects. 

Once the project is created, you'll receive a quick overview of the Unity interface, which is an essential part of navigating the development environment. The tutorial covers important panels such as the **Scene View**, **Hierarchy**, **Project Panel**, and **Inspector**. Understanding these elements is crucial because they provide the tools you need to manipulate game objects, create assets, and manage scripts throughout the development process.

### 2. **Designing the Game World**
Before jumping into gameplay mechanics, it's important to set up the game world. The tutorial begins by cleaning up the initial Unity project. By removing the default example assets, you create a blank canvas for your own game objects.

Next, you'll dive into designing the game world for *Cyberpong*. The basic gameplay and visual style are discussed. The core concept revolves around two paddles (player and AI-controlled) and a bouncing ball. The tutorial emphasizes that your game world doesn't need to be overly complex for this type of game. Instead, focus on the gameplay mechanics first.

You will also import pre-made 3D models for the arena, player rackets, and the ball. Importing assets into Unity is a fundamental skill, as it allows you to quickly add professional-quality objects to your scene without having to create everything from scratch.

### 3. **Implementing Player Controls**
With the game world designed, it's time to start making the game interactive. The first step here is to place the arena, player rackets, and ball into the scene. You'll also set the initial position and rotation of the player rackets, ensuring that they are positioned correctly within the game world. These placements are critical for gameplay as they define where the player and AI will interact with the ball.

The next step is to focus on the ball. The ball is a central element of the game, so you'll add it to the scene and apply a custom material to give it a distinctive look. Customizing the appearance of objects is essential for creating a unique visual style, especially in a game like *Cyberpong*, where you want to capture a futuristic, cyberpunk feel.

You'll also adjust the camera's position and orientation to provide a top-down view of the game. This view is essential for giving the player a clear overview of the game area and making it easier to control their paddle and track the ball's movement.

### 4. **Programming the Ball's Movement**
At this point, you'll start adding behavior to the ball. The ball is a key element of the game, so its movement needs to be programmed. You’ll make the ball a **kinematic rigidbody**, which allows you to manually control its movement while still enabling it to interact with the physics engine for collision detection. This method gives you more precise control over the ball's movement, which is essential for gameplay.

You'll then set up collision detection between the ball and the player rackets, as well as the walls of the arena. When the ball hits a racket or a wall, its direction will change accordingly. This interaction is crucial for the game's flow, as it simulates the classic Pong dynamics.

To make the gameplay more dynamic and unpredictable, the tutorial introduces randomness to the ball's initial direction. This adds an extra layer of challenge and excitement, as the ball's movement won't always be predictable.

### 5. **Introducing an AI-Controlled Opponent**
Once the player’s controls are set up, the next step is to implement an AI-controlled opponent. This allows you to play *Cyberpong* by yourself, with the AI acting as the second player.

The first part of this section involves creating a toggle feature that lets players choose between playing against a human or an AI opponent. This adds flexibility and makes the game more accessible.

For the AI-controlled racket, you’ll program the AI to follow the ball's position along the z-axis. This behavior makes the AI feel responsive and challenging, as it constantly tracks the ball's movement and moves accordingly. While the AI is basic, it serves as a foundation, and you can later refine it with more advanced techniques like predictive movement or difficulty scaling.

### 6. **Scoring and Game Reset**
Scoring is an important part of any game, and *Cyberpong* is no exception. In this section, you’ll create goal detection areas on the left and right sides of the arena. These areas will detect when the ball crosses the boundaries, indicating a goal has been scored.

Once a goal is scored, you need to notify the game that a point has been made. This is done by developing a **Goal Controller** script that listens for ball collisions with the goal areas. When a goal is scored, the script triggers the **Game Controller**, which handles the game's overall logic.

After a point is scored, the ball's position is reset to its starting point, and a new round begins. A countdown timer is implemented to add a brief pause before the next point starts, creating a smooth flow between rounds.

### 7. **Adding Visual Effects and Audio**
No game is complete without visual flair and audio to enhance the experience. In this section, you will add visual effects to give the game a cyberpunk aesthetic. For instance, you'll add particle effects such as smoke to the player rackets, making them look sleek and futuristic.

When the ball collides with the rackets or walls, spark effects will be spawned, adding excitement to each interaction. These visual effects are simple but effective in making the game feel more immersive and dynamic.

Finally, the tutorial covers the addition of background music. You'll add an **AudioSource** component to the camera and link it to a music track that will play throughout the game. Music enhances the atmosphere and keeps players engaged, making the gameplay experience more enjoyable.

### Conclusion
At the end of the tutorial, you will have successfully created a *Cyberpong* 3D game with a fully functional player, AI opponent, scoring system, visual effects, and audio. The tutorial wraps up by encouraging you to experiment with the game further, offering suggestions for future improvements or features to add. This beginner-friendly guide serves as a great introduction to Unity and 3D game development, giving you a solid foundation to build on for future projects.

By following along, you should now have a deeper understanding of how to use Unity's interface, how to design and implement 3D game mechanics, and how to integrate art, sound, and visual effects to create a complete, interactive experience.
