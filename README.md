# Tic-Tac-Toe-
Tic Tac Toe 

Make sure you download and run the SQL Querry using Microsoft SQL Sever Management

Assumtion:
I assume that the company has an severs API endpoint to store and retrieve the data for the users and their games

Features:

TIc Tac Toe Games using javascript
	How it works:

		I used bootstrap to make a 3x3 table with buttons on them
		whenever a player presses the buttons it will change the display from nothing to either O, X
		it have a listener game.js which listens for the event of a button with square class being click
		if so it will run the event to change the turn and display.

Able to post to an SQL sever using endpoint found in appsetting.json
	How it works:

		There is a hidden form that will be fully filled in once the win conditions are met
		Once they are met the javascript will click on the submit of the form and Post it to the sever

Features did not implement:
	
	Text to speech

	Multi player from differenet browers

How I would have Implement the feature:
	
Text to speech :

	There were attempts to try and use the given API of SpeechSynthesis.
	Problems I encontered: I made a simple code to try test out the speech but was not able to figure out why there was no sound
	The was no console error from the page. I check that Microsoft Edge has synSpeech but I was unable to figure out the root of the issue.

MultiPlayer:

	I didn't really know of any software that allows for real time communication between two differenet browsers.
	From my research I found that I could use signalR to transfer messages between browsers.

	I would have added them to the game.js for each button click would send a message 
	to the other player about the new move

	then the display would refresh and show the new move into the other player.
	I would have also made it where if its not the players turn,( player1 == turn == 1 ) they were not allowed to press any buttons or send
	However due to my inexperience and time constraints I was unable to apply this feature


Steps:
1) Clone the repository onto visual studio 2022
2) Open and Run the SQL Reposotory (Tic Tac Toe.sql) 
3) Run the repository 
