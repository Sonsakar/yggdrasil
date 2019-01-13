# Yggdrasil repository
Find .json files in "Yggdrasil > Yggdrasil > bin > Debug > files"  

Maybe use draw.io or something similiar to actually draw and connect story blocks

Game now has sound! Refer: https://github.com/naudio/NAudio
#### Story .json
<span style="color:red">Important: </span>json format changed! Added "area" (int value, leave 0 for now)

#### Logos
Logos are stored in yggdrasil/Yggdrasil/pic/

#### Character .json
Name files from "0.json" to "n.json". In "skills" fill out numbers based on specific character skills.
> positions in array must stay the some through project
>
> [vigor, endurance, strength, dexterity, perception, luck, intelligence, magic]
>
> 0 is lowest, 100 is highest. 100 meaning certainty. To make Baldur indestructable, set corresponding value to 100 (can and will be ignored in mistletoe situation)
