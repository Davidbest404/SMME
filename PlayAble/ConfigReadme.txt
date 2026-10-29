Config.ini Guide:
----------------------------------------------------------------------------------------------------
SimpleMating

Makes the mating process far simpler
The normal mating process is as follows (Player will be Blessing if you have one):

Slave.Mother    Slave.Father   Player.Mother    Player.Father
            \  /                            \  /
             \/                              \/
        Temp Child 1                    Temp Child 2
                    \                  /
                     \                /
                      -------  -------
                             \/
                            Child

The simple mating process is as follows (Player will be Blessing if you have one):

Slave    Player
     \  /
      \/
     Child

0 (default): Normal mating process
1 : Simple mating process
----------------------------------------------------------------------------------------------------
ComplexMating

Makes the mating process more complex so that a slave's unique genetics will be included
The complex mating process is as follows (Player will be Blessing if you have one):

Slave.Mother    Slave.Father   Player.Mother    Player.Father
            \  /                            \  /
             \/                              \/
        Temp Child 1                    Temp Child 2
                    \                  /
                     \                /
                      ------    ------  Slave    Player
                            \  /              \  /
                             \/                \/ 
                        Temp Child 3      Temp Child 4
                                    \    /
                                     \  /
                                      \/
                                     Child
                                        
0 (default): Normal mating process
1 : Complex mating process
----------------------------------------------------------------------------------------------------
AutoSort

Automatically sorts slaves by race when adding to the dungeon

0 (default): No sorting is performed
1 : Slaves are automatically sorted
----------------------------------------------------------------------------------------------------
PlayBGM

Configures whether the BGM in the bgm folder will be played

0 : BGM will not be played
1 (default): BGM will be played
----------------------------------------------------------------------------------------------------
FastText

Increases the display speed of text in dialog boxes 

0 (default): Text will be displayed at regular speed
1 : Text will be displayed at faster speed
----------------------------------------------------------------------------------------------------
ShowFPS

Displays the current game FPS in the title bar of the game window

0 (default): FPS will not be displayed in the title
1 : FPS will be displayed in the title
----------------------------------------------------------------------------------------------------
BigWindow

Changes the window size from 1024x768 to 1280x960
Using this with HighQuality will cause huge frame drop

0 (default): 1024x768 window size
1 : 1280x960 window size
----------------------------------------------------------------------------------------------------
NoScaling

Since v3.2 BigWindow will scale up buttons/other things to make it look more like the normal window
Turn this on if you perfer the old BigWindow look

0 (default): Button are scaled up
1 : Buttons are not scaled up
----------------------------------------------------------------------------------------------------
HighQuality

Makes the graphics render at higher quality
Using this with BigWindow will cause huge frame drops

0 (default): Normal quality graphics
1 : High quality graphics
----------------------------------------------------------------------------------------------------
AntiAliasing

Makes the graphics a lot sharper

0 (default): Aliasing
1 : Anti Aliasing
----------------------------------------------------------------------------------------------------
SensesButton

Displays the "Senses" button that shows the current slave's sizes, mood, and sensitivities

0 (default): Button not displayed
1 : The button is displayed
----------------------------------------------------------------------------------------------------
FixInfo

Some PC's seem to render text incorrectly resulting in misaligned stats info
This will make the senses info box a bit wider, hopefully fixing the error

0 (default): Info box is normal size
1 : Info box is wider
----------------------------------------------------------------------------------------------------
JsonButton

Displays the "SaveJSON" and "LoadJSON" buttons to allow saving/loading JSON files
This lets you edit your save files by turning them into a JSON file
Turn on TranslateJson to translate the generated JSON files into english

0 (default): No buttons are displayed
1 : The 2 buttons are displayed
----------------------------------------------------------------------------------------------------
TranslateJson

Translates the JSON files generated by JsonButton according to Translate.json in the text folder

0 (default): Normal JSON text
1 : Translated JSON text
----------------------------------------------------------------------------------------------------
MoveButton

Displays 4 buttons in the slave selection screen that allow you to move the position of slaves
These buttons allow you to move the slaves Up/Down Rooms/Floors

0 (default): No buttons are displayed
1 : The 4 buttons are displayed
----------------------------------------------------------------------------------------------------
StaminaButton

Displays 2 buttons in the training screen that allow you to reset slave/player stamina

0 (default): No buttons are displayed
1 : The 2 buttons are displayed
----------------------------------------------------------------------------------------------------
EditorButton

Displays a button that opens up a very simple in game data editor
A lot of game data is not displayed in this editor, use the JsonButton for more in-depth data editing

0 (default): No button are displayed
1 : The button is displayed
----------------------------------------------------------------------------------------------------
RefreshStoreEveryTime

Refreshes the slaves in the office store every time you click "Purchase"
This is to make it easier to generate new slaves without having to go back and sleep

0 (default): Store refreshes after every new day
1 : Store refreshes every time entered
----------------------------------------------------------------------------------------------------
HumanInStore

Generates Human slaves in the Humanoid section of the office store

0 (default): Human slaves don't generate in the store
1 : Human slaves generate in the store
----------------------------------------------------------------------------------------------------
AlwaysUseName

Always displays the slave's "Name" value instead of it's "種族" (Race) value in the box on the left
The "Name" value of a salve is from an unfinished feature that allowed naming slaves when they were trained
This feature still works, there is just no way to do it in game. To name a slave you must do it in the JSON

0 (default): "Name" will only be displayed when slave is trained
1 : "Name" will always be displayed
----------------------------------------------------------------------------------------------------
MoveInsectMask

When an insect race slave becomes trained, their eye mask will move up onto their forehead
Turn this option off if you do not want this happening

0 : Insect eye mask will not move up when trained
1 (default): Insect eye mask will move up when trained
----------------------------------------------------------------------------------------------------
WhipScars

Using the whip at 2/3 strength will have a 2% chance of applying a permanent scar to the slave

0 (default): Whip does not apply permanent scars
1 : Whips will apply permanent scars
----------------------------------------------------------------------------------------------------
NoFarting

Disables the chance for a slave to make a farting sound to occur during anal

0 (default): Slave makes farting sounds
1 : Slave does not make farting sounds
----------------------------------------------------------------------------------------------------
NoPissing

Disables the chance for a slave to start pissing after cumming

0 (default): Slave can piss after cumming
1 : Slave cannot piss after cumming
----------------------------------------------------------------------------------------------------
EncryptSave

DEBUGGING PURPOSES ONLY

By default, the game first compresses and then encrypts saves before writing them to file
Turning this off will allow the game to save the raw data rather than the compressed encrypted data
This along with DecryptLoad should always be kept on
If turned off, old saves will no longer work and new save files will be quite big
This and DecryptLoad should only be turned off for debugging purposes such as comparing raw saves
However, no matter what these are set to, JSON saving/loading will still work

0 : Game will save unencrypted uncompressed raw save files
1 (default): Game will save compressed encrypted save files
----------------------------------------------------------------------------------------------------
DecryptLoad

DEBUGGING PURPOSES ONLY

Allows the game to load raw save files generated by saving with EncryptSave on

0 : Game will load unencrypted uncompressed raw save files
1 (default): Game will load compressed encrypted save files
----------------------------------------------------------------------------------------------------