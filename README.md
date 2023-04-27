# Paint Editor

***PLEASE NOTE: You will have to open the program and build a release verison. I tried to figure out how to upload in but was not able to figure it out. ***

This project serves as a simple paint editor that allows a user to create drawings and export them into SVG files. The user can save their work into bitmap files and load them up to continue at a later time. It allows users to draw shapes such as rectangles and Ellipses, and free draw lines. It also allows for users to erase their work and a Select feature with transform and delete capabilities


## Getting Started

### Dependencies

Visual Studio will be needed to run the code. 

### Features

The program has the following features:

- Draw shapes (rectangle and ellipse)
   it has the ability to draw 2 shapes, and have the shape be shown when drawing.
   
- Free draw
   Allows the user to draw whatever they want.
   
- Eraser
   Allows the user to erase what they have already drawn
   
- Thickness controls for marker and shape drawing
   Allows the user to change the colours/thickness of lines using UI in the Toolstrip
   
- Undo/ Redo functionallity
   Allows the user to undo or redo an action.
   
- Pointer location view  (bottom of screen)
   Allows user to see the mouse location at any given time
   
- Item List and Property grid
   just displays the lines and shapes created, with some details being shown when you select a shape or line
   
- Select feature with Transform and Delete option available on right click after selecting an area. 
   Allows the user to select an area with a rectangle, then right click and transform or delete the selected area.
      Transform allows you to select a new area in the drawing area and resize/flip the orientation of the selected area based on mouse movement.

- Item List and Property view
   Allows user to see a list of lines or shapes they have drawn, and when selected, see the properties of that shape or line. 

- Save, Open, and New
   Allows the users to save the current work to a bitmap file through the File menu. It also allows the User to open a bitmap file to continue
   working on. Should they wish to start something new, it will clear the picture area and all the info from previoulsy drawn items. 

- Export to SVG
   Allows users to export the current drawing into an SVG file through the file menu.
   
- Help
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

### Saving over an existing file

I was not able to save over existing files. 


## Authors

Michael Bielawski

## GUI Screenshots

<img width="228" alt="Screenshot 2023-04-26 at 9 26 46 PM" src="https://user-images.githubusercontent.com/122567791/234740026-8ac07c98-e2a7-4c44-87d1-cefc3cf5f6ae.png">
<img width="1439" alt="Screenshot 2023-04-26 at 9 26 27 PM" src="https://user-images.githubusercontent.com/122567791/234740029-53b58663-2ade-434b-a53d-5ca9fc5525e9.png">
<img width="199" alt="Screenshot 2023-04-26 at 9 26 34 PM" src="https://user-images.githubusercontent.com/122567791/234740032-8f5a1b27-833d-4b77-8383-4f05aeb7fb50.png">
<img width="269" alt="Screenshot 2023-04-26 at 9 26 51 PM" src="https://user-images.githubusercontent.com/122567791/234740034-435a1d87-6781-41c8-b7d8-3c084996358d.png">
<img width="196" alt="Screenshot 2023-04-26 at 9 26 39 PM" src="https://user-images.githubusercontent.com/122567791/234740036-4c303974-90e4-4a0b-974d-0f19803de313.png">
<img width="671" alt="Screenshot 2023-04-26 at 9 27 07 PM" src="https://user-images.githubusercontent.com/122567791/234740037-0fa61289-d416-41dc-b83a-11a7f49616b8.png">


## Acknowledgments

Inspiration, code snippets, etc.
https://www.w3schools.com/cs/index.php  --- used many of these for more background understanding.
https://www.w3.org/  --- used for XML and finding the SVG namespace
https://svgwg.org/svg2-draft/struct.html#Namespace  ----  SVG info
https://svgwg.org/svg2-draft/refs.html#ref-xml-names  ---- SVG info
https://www.flaticon.com/search?word=erase --- used to find icons
https://www.dotnetperls.com/ --- more C# assistance and learning
https://stackoverflow.com/questions/1060442/png-to-bmp-in-c-sharp  --- bitmap learning
https://stackoverflow.com/questions/1053052/a-generic-error-occurred-in-gdi-jpeg-image-to-memorystream --- issue with memory stream for saving
https://chat.openai.com/?model=gpt-4 --- assistance in modifying errors
https://stackoverflow.com/questions/29717005/draw-a-rectangle --- select rectangle help.
https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/getting-started-with-graphics-programming?view=netframeworkdesktop-4.8 -- lots of help dealing with graphics, also helped with using stream writer and XML writer
https://gist.github.com/DomPizzie/7a5ff55ffa9081f2de27c315f5018afc --- readme template

chris diggins SVG editor program. Also big shoutout to Antoine for being such a good friend and helping me talk through some bug that i encountered.
