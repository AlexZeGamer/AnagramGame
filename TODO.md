# TODO

### To do
- [ ] Before submitting:
  - [x] Check the functional and operational tables a last time
  - [ ] Comment the code properly
  - [ ] Send a release on GH
- [ ] Display an error if the word list is not found (with instructions to put it back)
- [ ] Make a way to export results?
- [ ] Make a win animation ? (like in Solitaire)
  - [ ] Transparent gif on a transparent frame?
- [ ] Check keyboard navigation for the config popup
- [ ] Update README.md
  - [ ] Add new screenshots:
    - [ ] Make a gif with different themes
    - [ ] Show the config popup (the two tabs) as a gif
    - [ ] Show screenshots in different languages
    - [ ] Show screenshots in different versions of Windows
  - [ ] Add a list of features

### In progress
- [ ] Make a configuration popup where we can:
  - [ ] difficulty presets (easy, medium, hard)
  - [ ] change the language of the UI (move existing comboBox to the config popup)
  - [ ] Chose if we want the accentuated letters to be considered as the same as the non-accentuated ones (default to true)
  - [ ] Bugfix : The text bar is not keyboard focused when starting a new game (probably because the text bar is not enabled early enough)

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
- [x] GitHub :
  - [x] Make a README.md (List of features, how to compile, screenshots, etc.)
  - [x] Make a .gitignore
  - [x] Move this TODO to a separate file
- [x] Check if the guess contains all the letters shuffled
- [ ] Config popup :
  - [x] change the language of the word list
  - [x] select a custom word list
  - [x] change the number of tries
  - [x] define the min and max size of words (with a cursor)
  - [x] Save confinguration in a file
  - [x] Themes :
    - [x] Presets?
      - [x] Dark mode ?
    - [x] Custom theme with a color selector for the background
    - [x] Auto complementary color for the text?
    - [x] Button to reset the theme to default
  - [x] Bugfix : When opening the "Appearance" tab, the ForeColor of every object is updated to white by default
  - [x] When saving configuration, ask if we want to save and restart the app or cancel the changes
  - [x] Chose if we want the game to prevent us from guessing a word that is not an anagram of the shuffled word (default