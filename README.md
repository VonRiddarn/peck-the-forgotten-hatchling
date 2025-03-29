# Peck: The forgotten hatchling 🐣

Source code!

## About

This is the open source for the game "Peck: The forgotten hatchling".  
A game made for the JDS Easter jam 2025.  
You can play the game here: **TODO: Insert link when the game is done**

## Disclaimer

This project does not make use of Fractal Pike's in-house utilities.  
All assets were created specifically for the jam.

## Broken conventions and the reasoning

### Using public fields instead of properties

Due to this project being developed for WebGL nearly all decisions will be made around performance.  
Properties adds a redundant dive in the call stack - therefore fields will be used directly.  
To differentiate true public fields from fields that should be treated as properties, we use PascalCase for non true public fields.

`Health` public field posing as a property.  
`health` true public field.
