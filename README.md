# GDIM33 Vertical Slice
## Milestone 1 Devlog

### Prompt 1

<img width="960" height="720" alt="Breakdown " src="https://github.com/user-attachments/assets/d7de78d1-6f9f-4725-aced-363c660bd812" />

  Pictured above is a visual scripting graph attached to  my empty “SFX Manager” in my game space. The starting node for this graph is an on update node meaning that this graph’s logic is being constantly checked and runned every frame the game runs. Through this update node, the graph then checks if the player is pressing space with the get key down node, and using an if statement node, in the event that input is true the logic will proceed through, grabbing an object variable “Speaker” which is an audio source as well as a specific audio clip and then playing this sound and making it heard by the players. Looking at this from a player’s perspective, every time they press space to move through dialogue, a small 8 bit selection sound effect will play. 


### Prompt 2


<img width="1312" height="857" alt="Screenshot 2026-04-28 191844" src="https://github.com/user-attachments/assets/6a016c67-9c6a-44ec-979c-896bd56f1a20" />

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

<img width="1186" height="713" alt="Screenshot 2026-05-12 213414" src="https://github.com/user-attachments/assets/65b08a78-b8f7-4286-9f2d-f10652e4949c" />


An instance where I was calling a C# method inside of a visual scripting graph can be found in a start game graph that is a component to my start game button from my start game scene. Within this graph there's the on click event node and attached to it would be a node that is calling my Start Game C# script's Go to Opening Cutscene method. With this, when the game runs and the player clicks on the Start game button, it will launch them to the game's opening cutscene. 

### Prompt 3

The Unity System that I have used is Timeline and it is being used in my OpeningCutscene Scene, Walk Scene and Drink Scene. With timeline I created both an opening cutscene that gives the readers some context prior to playing the game and some transition scenes to make the jump between interactions more smoother.


## Milestone 3 Devlog

### Prompt 1

I currently use two shader Graphs in my game: one is simpler, while the other is more complex.


<img width="1912" height="1177" alt="Screenshot 2026-05-28 212146" src="https://github.com/user-attachments/assets/7ee1d35f-5676-44d8-810a-6fa5a8542c19" />

<img width="1919" height="1152" alt="Screenshot 2026-05-27 191900 (1)" src="https://github.com/user-attachments/assets/0ecf57ec-704e-4896-b67b-0080c732d355" />



My first shader graph appears when the player first opens the game in the start game menu. This shader is a simple sprite unlit shader that has tinted the original picture of the start game menu’s image. The graph uses two properties: a color property that is assigned the color red, and a texture2D property that contains the image of my start game menu. Using a blend node, I combine both the game’s image (in the sample texture 2D node) and the color node. Originally, the output of this blend node was just a red screen, but after I had tweaked the blend node's opacity and then swapped the modes into overlay to receive the proper effect that I wanted. Other than this, the split node was to ensure that the color variables and the alpha variables were able to go to their correct outputs, thus meaning that there was no alpha going into the color output and vice versa. 


The second shader graph is shown only in the first dialogue sequence of the game (since I want to improve/replace it in the future), and it is a small outline around the left edges of one of my sprites. To achieve this effect. I had grabbed the original texture of my sprite and created an offset with its UV, as seen through the use of the tiling and offsetting graph. I had offset the x-axis by 0.01, which makes the sprite move slightly to the left. Then, using a subtraction node.  I’ve subtracted the alphas of the original sprite and the offset sprite. What this does is that it identifies the edges of the new sprite and removes any spaces that overlap with eachother which is why the resulting image is only the outlined region of the sprite. Since the offset sprite is slightly to the left, it isn’t canceled out by the placement of the original sprite. Then, to apply the color, I used a multiply node that takes the subtraction output and layers it with a yellowish color. Finally, using an add node, I take the original sprite and add it to the finished outline, combining the two to show the original sprite with an additional yellow outline. Once again, the split node was used to separate the alpha and the color variables within its designated outputs. 

### Prompt 2

In regards to the playtesting feedback,  a big thing that was mentioned was that they wanted to see some kind of UI fixes: one to see the text better and another to get some kind of indicator of when they can actually click through dialogue after the cutscenes end. To achieve this I had simply changed my characters name to white and changed the opacity of the UIs boxes. I had also activated the characters dialog object so after the cut scene transitions, the players will see a character spawn indicating that they’re able to now play through the game!

### Prompt 3

In terms of added game content my vertical slice now has 4 out of the 8 possible endings.  The player can continue along the story line and read through a lot more dialogue. I have also implemented instances where the player can pick three instead of 2 choices. This helping balance out the odds of getting sent into a certain ending. Though there’s still some art that is going to be added the original two transition art have been completed and polished in contrast to their original forms which were just rough sketches. Listed on the itch are instructions to see the more advanced storylines. From here I plan on adding the final four endings, more art and use of timeline and possibly expanding the dialogue and questions in each route. 

## Final Devlog


### Prompt 1

In my Vertical Slice of “Kalidescope eyes”, the core gameplay loop is that the player reads lines of dialogue and clicks to advance the story and get a good grasp of the character they play and the setting. Eventually, during their read-through, they are given the ability to make choices for themselves, and by clicking on their choices, not only do they lead to unique dialogue that is only obtained from the choice they made, but their choices are also valued. Depending on their score, at the end of each scene, the player will be sent to a new experience depending on the value of the choices they made in the scene prior. This cycle of reading dialogue and making choices that eventually jump you to a new scene or ending is the overall gameloop of this visual novel. 

Looking back at my Vertical slice plan, I was able to execute the same gameplay loop that I had intended, with the dialogue, choices, and scene jumping mechanics running smoothly. Looking at the bigger picture, the gameplay loop and content that have been involved in this Vertical slice, the player can see that this game is very narrative-heavy due to the amount of reading involved: they also see that their choices hold value, which has them thinking what move should be made to get a better ending. The players also see the replayability of the game, considering how many choices, dialogue that can be explored, and the endings they are able to obtain. Other than this, the players get a good understanding of the characters involved in the story through their interactions, and the music and visuals help develop the feel of the game aesthetically. 


### Prompt 2

The rendering effect present in my game that is activated through gameplay logic is found when the player first loads the game. In the start game menu, there is now a card on the top left of the screen. If the player clicks e, the menu blurs, and a new UI pops up, which is a simple, fun little introduction to the game’s storyline. Connected to the start menu art is a material that is attached to a blur shader graph. To get the blur to activate, I used a C# script “StartGameBlur” to edit the material once commanded to (when the player presses “e”)

<img width="1918" height="1145" alt="Screenshot 2026-06-10 215637" src="https://github.com/user-attachments/assets/20ce6a7b-b20a-4492-8665-2e83b644418a" />


Within the script, it has 4 different variables: one to attach the game art’s material, a bool, a float that registers the material’s blur amount, and the game object that has the UI that will pop up after the menu blurs. In the start method of the class, it registers the materials blur as well as the UI to be shut off. Then, within the game’s update method, using an if statement, it registers when the player clicks e, and as a result, the UI will pop up, and it registers that the material should start blurring. Following this is another if statement that processes if that bluractive bool is set to true, the blur amount will be multiplied by blurspeed (a variable that processes how fast the transition should be to activate the effect) and Time.Delta.Time. At the very bottom of the update method, the last line is where the material is being used, the C# calls “_Blur”, (a variable in the materials shader graph that controls the amount of blur added onto the image) and attaches it to the bluramount variable in the code, that way the shader’s blur is being controlled and tampered with through C#.


<img width="1907" height="887" alt="Screenshot 2026-06-10 215935" src="https://github.com/user-attachments/assets/dcba5e24-0b52-4f0d-9f5d-9fd9cb486c6d" />


From the shader graph, the “Blur_” reference is attached to the blur amount, which is connected to the multiply and combine function of the shader graph. The math behind this shader graph allows it so that, depending on the blur’s value, the two UVs from the left and right will be offset by that value, creating a blur effect.


### Prompt 3

When it comes to my production, process and breaking down a large project such as this, I first start by identifying the game’s individual systems: these systems are usually identified by the game’s core mechanics: For example: In a visual novel game the core mechanics would be clicking through character dialogue and having players select between a range of choices that impact the narrative progression of the game. Then, I find that breaking down these mechanics into smaller steps( as we learned this quarter ) really helped me understand how much work needed to be made into getting one mechanic down- breaking down a bigger mechanic into smaller more manageable tasks also helped me detangle my brain; a big problem when it came to approaching big projects is finding out where to start and I found that diagrams and bubble charts didn’t work that well for me considering it wasn’t sustainable or something I was able to look back at and be able to fully understand what was going on in my brain when I created said break down. After breaking it down into smaller and manageable tasks, I then list tasks on priority level, from what 100 percent needs to be added in the game to fit into the vertical slice, and what can be excluded from it or added ONCE the main priorities have been situated. 

This process of taking a game and breaking it into its mechanics and then proceeding to break those mechanics into its classes, game objects, and steps really helps with minimizing your scope. In this class, especially, it was really important that we didn’t get too ambitious with our ideas: It may feel like one small mechanic in a game, but seeing how many steps taken into implementing that mechanic can be very humbling. We also had to consider how much debugging or changes would need to be made upon feedback. With that being said, keeping the vertical slice limited to one to two mechanics seems more manageable, especially given the timeframe of only 8-10 weeks to complete it. When it comes to a vertical slice, quality of mechanics means more than quantity, so by cutting down the amount of work you want to put into your game, you can have a less stressful time polishing and getting in your more important pieces of the slice. In summary, don’t underestimate how much effort it takes to get into your “simple mechanics” because they require much more than you think. 

Relating this all back to the production of my vertical slice, knowing myself and knowing how long it takes for me to learn something and program, I knew for certain that I wanted there to be very simple game mechanics- with that being said A visual novel felt the best for me because it’s gameplay was all directed towards dialogue: I didn’t need to add any movement code or anything more complex to stack on top of the main dialogue function. Due to the fact that I was so intimidated by code, I found that breaking down all my code into little steps prevented me from procrastinating and prevented me from programming things at the last minute. Apart from my intimidation, I also took other things that needed to be done into consideration such as the sprites for the game, art, and getting the official writing down and wanted to make sure that I had not only enough time for programming but to include as much as I want for the visual and narrative content for the game while also taking account for my other classes/projects that I was involved in this quarter. With that being said, I wanted to be as minimalistic as possible for this game and wanted to stick to something simple and manageable, yet still adhere to the criteria wanted for the game. I was really on top of it when it came to programming, and luckily was able to implement all my main gameplay loop working early on in production; however, where I struggled was giving myself time to work on writing out the game. The game could have had more into its story and possibly more scene jumps if I had started earlier than I did when writing and fleshing out the dialogue. I think that if I had just put more consideration into writing as I did coding, even if it was just writing a little bit at a time per day, it could have done better for me than being stressed into writing more content for milestone 3 and cramming it in. Other than this, just being more wise with time and even taking into account burnout, especially since this quarter I was tackling a lot, and there were times where I just needed to rest.


## Open-source assets
- [Background Music](https://pixabay.com/music/traditional-jazz-jazz-lounge-relaxing-background-music-514554/)
- [Placeholder Background](https://unsplash.com/s/photos/casino)
- [Click SFX](https://sfxr.me/)
- [Start Game Menu Music](https://rustedstudio.itch.io/free-music-ambient-piano-jazz-tracks?download)
- [Card Asset](https://assetstore.unity.com/packages/3d/props/playing-cards-design-pack-160928)
- [Sfx for Bad state](https://sfxr.me/)
- [Sfx for Good state](https://sfxr.me/)
