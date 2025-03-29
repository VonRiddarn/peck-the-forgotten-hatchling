# Peck: The forgotten hatchling 🐣

Source code!

## About

This is the open source for the game "Peck: The forgotten hatchling".  
A game made for the JDS Easter jam 2025.  
You can play the game here: **TODO: Insert link when the game is done**

## Broken conventions

**Using public fields instead of properties**

Due to this project being developed for WebGL nearly all decisions will be made around performance.  
Properties adds a redundant dive in the call stack - therefore fields will be used directly to minimize overhead.
