# Beat Saber Game Switcher

### DISCLAIMER

This program, me or anything related with this project is **NOT** part of Beat Games or the Beat Saber trademark.

### About this program

Program that switches between your vanilla and modded Beat Saber instances. Why do something that takes 30 seconds if you can automate it in 2 days

### How to use

First of all, you need to compile it. Yes, I'm not releasing binaries because this is just a silly project, 
but if you are really interested, you can use **Visual Studio 2019 Community edition** to compile it.
This proyect does not require any extra extensions, libraries, whatever.

Second, onced compiled, run the program.
The first time a set up window will appear, you just select your **vanilla** and **modded** instances/folder of Beat Saber.

#### VERY IMPORTANT NOTE
Both folders need to be in the same parent folder, if not, only god knows what type of exceptions or errors this program will throw.

In my case, both folders are stored in `E:\Steam\steamapp\common`, my modded one is called `Beat Saber` and the vanilla one is called `Beat Saber_vanilla`.
The initial names are not that important but I highly sujest that at least one folder is called `Beat Saber`, as the *active* game instance.

Now save the config and the main window will appear, the first time you run it, there's high change of getting a empty button
(well, not exactly empty, but with only a hyphen), if that's your case, close the program and open it again.
Now it should be functional.

The process is simple, you have your vanilla instance active, just press the button and then your modded instance will be active and the vanilla one will be backed up, and viceversa.

#### More notes
The none active instance will just be renamed, for example, if the vanilla instance is active, the modded one will be called `Beat Saber_modded`, and in the
other way around too, if the modded version is active, the vanilla instance will be called `Beat Saber_vanilla`.

#### Final note
This is just a small program that I made in my free time. Bugs, typos, bad interface, crashes and flying cubes are expected (more often than you think).
