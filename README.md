# Paint Editor

***PLEASE NOTE: You will have to open the program and build a release verison. I tried to figure out how to upload in but was not able to figure it out. ***

This project serves as a simple paint editor that allows a user to create drawings and export them into SVG files. The user has the ability to save their work into bitmap files and load them up to continue at a later time. The program also allows users to draw shapes such as rectangles and Ellipses, and free draw lines. An erase function is also available to fix any mistakes in their work and a Select feature with transform and delete capabilities is also present, allowing them to move and resize the selected area or delete it altogeher.


## Getting Started

### Dependencies

Visual Studio will be needed to run the code. 

### Features

The program has the following features:

- Draw shapes (rectangle and ellipse):
   It has the ability to draw 2 shapes, and have the shape be shown when drawing.
   
- Free draw:
   Allows the user to draw whatever they want.
   
- Eraser:
   Allows the user to erase what they have already drawn.
   
- Thickness controls for marker and shape drawing:
   Allows the user to change the colours/thickness of lines using UI in the Toolstrip.
   
- Undo/ Redo functionallity:
   Allows the user to undo or redo an action.
   
- Pointer location view  (bottom of screen):
   Allows user to see the mouse location at any given time.
   
- Item List and Property grid:
   Just displays the lines and shapes created, with some details being shown when you select a shape or line.
   
- Select feature with Transform and Delete option available on right click after selecting an area:
   Allows the user to select an area with a rectangle, then right click and transform or delete the selected area.
      Transform allows you to select a new area in the drawing area and resize/flip the orientation of the selected area based on mouse movement.

- Item List and Property view:
   Allows user to see a list of lines or shapes they have drawn, and when selected, see the properties of that shape or line. 

- Save, Open, and New:
   Allows the users to save the current work to a bitmap file through the File menu. It also allows the User to open a bitmap file to continue
   working on. Should they wish to start something new, it will clear the picture area and all the info from previoulsy drawn items. 

- Export to SVG:
   Allows users to export the current drawing into an SVG file through the file menu.
   
- Help:
   A cute little help menu item that should provide a laugh to those in need. 




## Known Bugs

### Saving over an existing Document

I could not figure out how to save over an existing document with the same name. 

### Right click

I created a context menu for the select feature and was not able to get the context menu to only show up when the select mode is enabled. If you try to use the features in the menu outside of the select mode an exception is thrown. 

### Undo and Redo Behaviour

Sometimes Undo and Redo act up and get lost in the stack. Some items will duplicate or multiple items will be removed unintentionally. 

### Item veiwer

I was not able to implement the shape deatils for shapes in the property grid. This will be something i will work towards rectifying in the future. 


## Authors

Michael Bielawski

## GUI Screenshots


<img width="228" alt="Screenshot 2023-04-26 at 9 26 46 PM" src="https://user-images.githubusercontent.com/122567791/234746533-2e89b467-4dfd-4b58-85c2-e2560bb7d3e1.png">
<img width="269" alt="Screenshot 2023-04-26 at 9 26 51 PM" src="https://user-images.githubusercontent.com/122567791/234746535-349cf2d4-76fb-4137-a285-db85017e1a13.png">
<img width="1573" alt="Screenshot 2023-04-26 at 10 44 15 PM" src="https://user-images.githubusercontent.com/122567791/234746536-353992a8-acbc-4261-b4c3-b2a8a138f05d.png">
<img width="199" alt="Screenshot 2023-04-26 at 9 26 34 PM" src="https://user-images.githubusercontent.com/122567791/234746538-37d1b66b-172d-4e00-9ec0-ca656bf370b2.png">
<img width="196" alt="Screenshot 2023-04-26 at 9 26 39 PM" src="https://user-images.githubusercontent.com/122567791/234746542-b5a79b72-db35-4bd4-a123-5f4facd092a7.png">
<img width="671" alt="Screenshot 2023-04-26 at 9 27 07 PM" src="https://user-images.githubusercontent.com/122567791/234746544-6c048bd9-21f5-4d5e-9cad-759b20f943dc.png">


## Acknowledgments

Inspiration, code snippets, etc.
- https://www.w3schools.com/cs/index.php  --- used many of these for more background understanding.
- https://www.w3.org/  --- used for XML and finding the SVG namespace
- https://svgwg.org/svg2-draft/struct.html#Namespace  ----  SVG info
- https://svgwg.org/svg2-draft/refs.html#ref-xml-names  ---- SVG info
- https://www.flaticon.com/search?word=erase --- used to find icons
- https://www.dotnetperls.com/ --- more C# assistance and learning
- https://stackoverflow.com/questions/1060442/png-to-bmp-in-c-sharp  --- bitmap learning
- https://stackoverflow.com/questions/1053052/a-generic-error-occurred-in-gdi-jpeg-image-to-memorystream --- issue with memory stream for saving
- https://chat.openai.com/?model=gpt-4 --- assistance in modifying errors
- https://stackoverflow.com/questions/29717005/draw-a-rectangle --- select rectangle help.
- https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/getting-started-with-graphics-programming?view=netframeworkdesktop-4.8 -- lots of help dealing with graphics, also helped with using stream writer and XML writer
- https://gist.github.com/DomPizzie/7a5ff55ffa9081f2de27c315f5018afc --- readme template

- Christopher Diggins' SVG editor program. --- served as a great inspiration.
- Also big shoutout to Antoine for being such a good friend and helping me talk through some bug that i encountered.
