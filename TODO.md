# TODO

### To do
- [ ] Display an error if the word list is not found (with instructions to put it back)
- [ ] Check the functional and operational tables
- [ ] Check if the guess contains all the letters shuffled
- [ ] Dark mode ?
  - [ ] Custom theme with a color selector for the background
  - [ ] Auto complementary color for the text?
- [ ] Make a way to export results?
- [ ] Make a win animation ? (like in Solitaire)

### In progress
- [ ] Make a configuration popup where we can:
  - [ ] change the language of the word list
  - [ ] select a custom word list
  - [ ] change the number of tries
  - [ ] change the language of the UI
  - [ ] define the min and max size of words (with a cursor)
  - [ ] When saving configuration, ask if we want to save and restart the app or cancel the changes
  - [ ] Save confinguration in a file

- [ ] GitHub :
  - [ ] Make a README.md (List of features, how to compile, screenshots, etc.)
  - [ ] Make a .gitignore
  - [x] Move this TODO to a separate file

### Done
- [x] Known bug : if you win/lose and hit "no" then "no" you have to restart a game and it will be logged twice
- [x] Make it so we can give up and show the word (when pressing "New game" ?) => Puts the word in the games history when giving up a game
- [x] Make it so we can validate the word by pressing the "Enter" key
- [x] Make the "How to play" popup
- [x] Make the "About" popup
- [x] Check if the guess is the good length
- [x] Make it so the list of previous guesses and game history auto-scroll to the bottom
- [x] Make sure a word is shuffled (the shuffled word is not the same as the original word), else shuffle it again
- [x] Make it so we can copy a list item (previours guesses/games) when right clicking it
- [x] Put an icon on the form (that will show up in the taskbar)
- [x] Enhance keyboard navigation
  - [x] Choose appropriate default item on YesNo text boxes
  - [x] Make it so the default keyboard selected item is the guess text box
  - [x] Change tab navigation order