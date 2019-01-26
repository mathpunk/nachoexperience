# Nacho's Experience

# Primary Objectives
- Picture -> Bedroom
- Blues -> Studio
- Trader Jane's -> Cooking/Kitchen
- Cat -> Living Room

# Objective Clues
<<<<<<< HEAD
- Bedroom -> I need a vista to brighten up this room
- Living Room -> I miss my pet from back home
- Kitchen -> My mom made the best Milanesa
- Studio -> My brother loves the blues
=======
- Bedroom -> I need a *vista* to brighten up this room
- Living Room -> I miss my *pet* from back home
- Kitchen -> I miss my mom's *homemade* Milanesa
- Studio -> My brother loves the *blues*
>>>>>>> ded22c3399c9730e3f583aed99fae0d932c4f5fc

# Game Dynamics
- Wake up
- Walk around the house full of black and white rooms, when avatar enters room, reminder is played "Oh, I miss my cat"
- Water the tree (optional)
- Check the mail (begin day - makes you sad, no papers!)
- Go to the city
- Finish a clue
- Go back home
- Cinematic "welcome home" -> Room takes color or player gets more sad if no rememberal

# Code Requirements
- Scene Management/GSM class
-- and Camera Control class
- Character State Machine class
- Puzzle for studio (get Blues music)
- Puzzle for kitchen (get Milanesa from Trader Jane's)
- Puzzle for bedroom (get Picture of Chicago)
- Puzzle for living room (get a pet)
- Tree State Machine class
- Animal State Machine class
- Thought bubble/clue class
-- and String Manager class
- Abstract Room base class + Room Specializations
- Mailbox Interaction class
- Scene State Manager (puzzle master state)


# Assets
## Buildings:
- Music House
- Restaurant
- Grocery
- Sears Tower
- Tree (multiple states for watering + cat/squirrel in tree)
- Home with four rooms B&W
- Home with four rooms Color
- Millenium wheel
- Alley for cat (garbage bin)
- Thought bubble for clue
- Mailbox
- UI/Main Menu

## Animals:
- Crow
- Cat
- Rat
- Squirrel

## Sound effects:
- Latin music
- Blues
- Opera
- Steps/walking
- Cat Meow, Scratching, Purring
- Crow cawing
- Squirrel chitering
- Rat squeeking
- Mailbox

## Misc Assets:
- Sadness Bar
- Photos
- Phone and Icons
- City background + skybox
- Opening screen + menus
