# GDIM33 Vertical Slice
## Milestone 1 Devlog

### Prompt 1

<img width="1312" height="857" alt="Screenshot 2026-04-28 191844" src="https://github.com/user-attachments/assets/6a016c67-9c6a-44ec-979c-896bd56f1a20" />

  Pictured above is a visual scripting graph attached to  my empty “SFX Manager” in my game space. The starting node for this graph is an on update node meaning that this graph’s logic is being constantly checked and runned every frame the game runs. Through this update node, the graph then checks if the player is pressing space with the get key down node, and using an if statement node, in the event that input is true the logic will proceed through, grabbing an object variable “Speaker” which is an audio source as well as a specific audio clip and then playing this sound and making it heard by the players. Looking at this from a player’s perspective, every time they press space to move through dialogue, a small 8 bit selection sound effect will play. 


### Prompt 2

<img width="960" height="720" alt="Breakdown " src="https://github.com/user-attachments/assets/d7de78d1-6f9f-4725-aced-363c660bd812" />

  Looking at my updated breakdown in reference to my breakdown in earlier production of my game, I have added more details regarding the many different systems in my game since there is a lot going on behind the scenes. First change that I made was separating my dialogue system depending on the UI being used and separating it from having one system of the player being able to click through dialogue with the space bar (dialogue display script) and a system for identifying when the player has reached a question segment in which they must choose and click buttons which will not only lead to different dialogue segments but each choice has a value attached (either adding one or subtracting one) that contributes to a friendshipmeter, and depending on the players ending score when they reach their last interaction, they will be sent to the good ending or the bad ending scene. 


  Another big change that contributed to the way I constructed my breakdown is that when first picturing my game, I had only intended to have dialogue node scriptable objects but when I actually got to it I ended up making different kinds of scriptable objects that contribute to different parts of the game (even each other) I have a character scriptable object that holds a character name and sprite which is added to my conversation scriptable object which assigns lines of text with a character and can carry a question scriptable object another conversation, and a boolean that if check indicates that it’s the last interaction the player has before determining what ending they get sent to. Finally there's the question of scriptable objects that have choices that get added to buttons when the game runs as well as conversation outcomes (where the player gets sent if they click on said choice) as well as the point value they receive if they click on certain choices which eventually all add up to determine their ending outcome!


  As for my state machine, it is located in my EndingManager GameObject which has both the endingmanager script and the ending state machine as a component. The state machine graph has two states, a good ending state and a bad ending state, with two transitions made between the two states, to transition between states, it contains an if statement which tracks the points the player earns and compares it to the value of an integer variable “goodthreshold” which is the max points the player needs to receive the good ending, if the player succeeds this value they will be put in the good state and sent to the good ending and if the latter, they will be sent into the bad ending state  and sent to the bad ending. The use of this state machine is also integrated into the logic of the ending manager script, as it uses the same variables as the script for the variables that are being tracked in its transitions. The state machine helped a lot with debugging and checking to see if the logic in the ending manager script was properly functioning (ex. Making sure that the character was being sent to the correct ending). Some other systems this state machine collides with would be the question of scriptable objects since the scriptable object contains  the player's choices that  are assigned numerical values which add up and get sent into the ending manager and determine what state the player is currently in. 


## Milestone 2 Devlog

### Prompt 1 

Complicated Gamerplay feature: Different action/events happening depending on the player's friendship level. 

#### Step 1: Create an indicator that tells players how their friendship level is
1. Find and download 2 short sfx clips, one to indicate a low friendship level and one to indicate a good friendship level. 
2. import the sfx into unity
3. Inside of the EndingManager GameObject, attach the two sfx as an audio clip and add an audio source
4. In the state machine that the ending manager uses create 3 new variables, 1 audio source and 2 audio clips 
5. Open the state machine and inside of both the Bad ending state and good ending states "on state enter event" attach a play audio node that plays the desired audio clip for each state
6. Run game, with this attachment, the bad ending sfx should play and test to see when the player reaches the good threshold if the good ending sfx plays. 

#### Step 2: Lead the players to different cut scenes/dialogue depending on their friendhship level
1. Open the EndingManager Script
2. Rather than having the CheckEnding method load a specfic scene, create two string variables that will be loaded depending on the cutscene (that way this script can be accessible and used in branching scenes)
3. Assign in the inspector the cutsscene that will play if the player reaches a good firendship level versus a bad friendship level. 
4. Open the two time line cutscenes and create an empty scene changer gameobject and attach the scene changer script as  it's components. (similar nature to what the openingcutscene does once it finishes playing)
5. Create two new playable scenes that will launch in the endings scene changer AFTER the cutscene has finished playing (this will have it so that after the player has reached a certain cutscene they are able to continue gameplay rather than them being stuck on a screen after they finished dialogue.)


### Prompt 1- Post-Coding

Coming from someone who gets really intimidated by doing things that feel super complex, I do think that these task breakdowns were a nice way for my brain to understand that these intimidating things aren’t as complicated and stressful as I make them out to be. By breaking these tasks down into smaller steps it gave me the confidence to try and implement these things into my game and allowed me to finish them at an earlier time frame rather than holding them off due to fear. These breakdowns are also great references to look back at and they are easy to follow; for example, if I were to write a breakdown for my future self they would be able to see it and understand what to do (once again giving them less pressure when going in to work on the game. ) A world of advice that I would consider in future task break downs I might do is to get very very specific in your steps. The more little steps and details you add into a bigger step, the less confusion there will be when looking back at said tasks.

### Prompt 2

An instance where I was calling a C# method inside of a visual scripting graph can be found in a start game graph that is a component to my start game button from my start game scene. Within this graph there's the on click event node and attached to it would be a node that is calling my Start Game C# script's Go to Opening Cutscene method. With this, when the game runs and the player clicks on the Start game button, it will launch them to the game's opening cutscene. 

### Prompt 3

The Unity System that I have used is Timeline and it is being used in my OpeningCutscene Scene, Walk Scene and Drink Scene. With timeline I created both an opening cutscene that gives the readers some context prior to playing the game and some transition scenes to make the jump between interactions more smoother.


## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- [Background Music](https://pixabay.com/music/traditional-jazz-jazz-lounge-relaxing-background-music-514554/)
- [Placeholder Background](https://unsplash.com/s/photos/casino)
- [Click SFX](https://sfxr.me/)