# MMRGraph
AI play against themselves and are rated based on preformance

- Two arrays, one of AI and one of "games"
- Games are played by adding points to 5 different "colors"
- Colors are strong against certain colors and weak against others
- Colors aren't compared against neighbors and are half as strong as the color 2 spaces in front (and twice as strong as the color 2 spots behind)
- 1 point can be added to a color each round
- First to win 10 rounds wins the match or if the match goes on for 25 rounds it ends in a tie
- AI are matched based on an MMR system
- AI "learns" by randomly adjusting weights after losing


# Notes
- Currently rewriting the decision making structure of the AI
  - currently just focuses on a specific color
- Normally writes to a file but I have commented it out
- You are able to play against in AI but need to provide it weights
