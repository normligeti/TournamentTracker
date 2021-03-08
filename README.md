# TournamentTracker
-
This application was a part of a C# course.

It is a tournament tracker application where users can create tournaments with custom teams made of custom team members.
It handles an arbitrary number of teams, and automatically generates randomly paired matchups (with bye rounds where needed).
Users can enter the score of each match, and the app advances winners to the subsequent rounds.
All data is being saved to either an sql database or text files (uploaded version is set to text; filepath is relative, so it works everywhere).
The app also sends e-mail notifications about round, winner and prize information to corresponding team members via visual studio's built-in email client (works only on local network for now).
The application is done in .NET Framework 4.7, it uses Winforms UI, SQL database with stored procedures, text file data storage in CSV format.
