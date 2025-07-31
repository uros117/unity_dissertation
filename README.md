# 3D Labyrinth Ball Game - Unity 3D Implementation

This repository contains the Unity 3D implementation of a 3D labyrinth ball game, developed as part of a comparative study of 3D game development tools.

## About the Project

This is one of three implementations of the same 3D game, created to compare different game development technologies. The game is inspired by classic wooden labyrinth puzzles where players tilt a platform to guide a ball through obstacles to reach the goal.

## Game Features

- **Platform Control**: Rotate the labyrinth using keyboard controls (limited to ±30 degrees)
- **Physics-Based Ball Movement**: Realistic ball physics responding to platform tilt and gravity
- **Interactive Camera**: 
  - Perspective camera with mouse controls (right-click and drag)
  - Orthographic top-down camera
  - Camera switching with 'C' key
  - Zoom with mouse wheel
- **Game Elements**:
  - Wooden textured platform with obstacles
  - Multiple holes (traps and goal)
  - Goal hole with golden rim
  - Collision detection and physics
- **Visual Features**:
  - Skybox background
  - Textured materials (wood, hole textures)
  - Lighting system
  - Win condition with fade-out text

## Technology Stack

- **Engine**: Unity 3D
- **Language**: C#
- **Platform Support**: 22 platforms (Windows, Linux, macOS, consoles, mobile, web, etc.)

## Requirements

- Unity 3D (version used in development: 2022.x)
- Visual Studio or VS Code (optional, for code editing)

## How to Run

1. Clone this repository
2. Open the project in Unity Hub
3. Open the main scene
4. Press Play in the Unity Editor, or build for your target platform

## Controls

- **Arrow Keys / WASD**: Tilt the platform
- **Right Mouse Button + Drag**: Rotate perspective camera
- **Mouse Wheel**: Zoom in/out
- **C Key**: Switch between perspective and orthographic cameras

## Project Structure

The project follows Unity's standard structure with scripts organized by functionality:
- Ball physics and movement
- Platform rotation and controls
- Camera management
- Collision detection
- Game state management
- UI elements

## Performance Metrics

According to the comparative study:
- **Development Time**: 22 engineer-hours
- **Lines of Code**: 201
- **Executable Size**: 71.7 MB
- **Memory Usage**: 76.9 MB
- **Project Size**: 337 MB

## Related Repositories

This implementation is part of a larger comparative study. See also:
- [Bevy Implementation](../bevy-labyrinth-game)
- [JavaFX Implementation](../javafx-labyrinth-game)
- [Main Repository with Thesis](../3d-game-development-comparison)

## Academic Context

This implementation was developed as part of a bachelor's thesis at the University of Belgrade - Faculty of Electrical Engineering, comparing three different approaches to 3D game development.

**Thesis**: "Comparison of Tools for 3D Video Game Development in JavaFX, Bevy, and Unity 3D Technologies"  
**Author**: Uroš Filipović  
**Mentor**: dr Igor Tartalja, v.prof.  
**Year**: 2022

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Survey Results

In user testing with 21 participants, this Unity implementation received:
- **Graphics Quality**: 8.33/10
- **Responsiveness**: 8.38/10  
- **Overall Rating**: 8.38/10
