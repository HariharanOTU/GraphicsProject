# GraphicsProject

Base
- [X] Movement
- [X] Scene
- [X] Enemies
- [X] Win/lose
- [X] Timer

2 Lighting shaders
- [X] Lambert Diffuse
- [X] Ambient Diffuse
- [X] Toggle

LUT
- [X] 3 LUTs
- [X] Toggleable LUT Script
- [X] Swappable LUT materials

2 Additional shaders
- [X] Reflection probe
- [X] Rim lighting

Explanation
- [X] Video
- [X] Google slides
 
Playlist(Unlisted) for presentation and Demo video: https://youtube.com/playlist?list=PL0o7UHm4zj_RK2VkCNivnPhF4fVhhzuPu

The game is meant to be a rough prototype of the Graphx Project proposal, with a tower that the player can climb and 2 enemies that move in a circular pattern that kill the player on collision. 

The player can also win by running down the timer, meant to be a stand in for the waves.

The player can move using WASD and the mouse, as well as control the tower's illumination with the first 3 numerical keys(1- No shader, 2 Lambert Diffuse, 3-Ambient Diffuse), and activate and deactivate a camera shader with 4, and set modes for that shader with 5-7.

The camera shader when activated starts with a warm lookup table that's also tied to 5, a cold table on 6 and a custom one on 7.

The project includes several illumination shaders, the implemented ones being a Lambert diffuse shader and an Ambient Lighting diffuse shader as previously done in the lectures. 

The shaders include a reflection probe on the floor and slopes set to the skybox, as well as a completed hologram shader that wasn't completed during the lecture exercises, which is set to the enemies and walls of the level.

https://docs.google.com/presentation/d/1aiM1OLH1J2-AGaeMzw5ghVmPp14qSu2_LiMpljN2Bo0/edit?usp=sharing
