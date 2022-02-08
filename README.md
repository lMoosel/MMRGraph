# MMRGraph
AI play against themselves and are rated based on preformance

- Two arrays, one of AI and one of "games"
- Games are played by adding points to 5 different "colors"
- 1 point can be added to a color each round
- First to win 10 rounds wins the match or if the match goes on for 25 rounds it ends in a tie
- Rounds are won by a random comparison between colors
- AI are matched based on an MMR system
- AI "learns" by randomly adjusting weights after losing


# Notes
- Normally writes to a file but I removed the file path
- You are able to play against an AI but need to provide it weights
