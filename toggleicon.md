Something **completely optional** that I found helpful for my workflow writing C# in VS Code was using the following extension to add some keyboard shortcuts to add a semicolon to the end of the current line and optionally create a new line (and move to it). Semicolons are going to be your new best friend!

```
Name: toggle semicolon
Id: awesomektvn.toggle-semicolon
Description: toggle semicolon, colon and comma
Version: 0.0.1
Publisher: awesomektvn
VS Marketplace Link: https://marketplace.visualstudio.com/items?itemName=awesomektvn.toggle-semicolon
```

Once you have it installed through the extensions tab, you can bind the command it installs to your keyboard shortcuts. Open the command pallete (shift+ctrl+p on windows, something similar on osx) in VS Code and search for `>Open Keyboard Shortcuts (JSON)`. This should open up your KeyBindings.json, here you can add any key bindings you'd like! 

I set `ctrl+;` to toggle semicolon on current line, and `shift+ctrl+;` to toggle semicolon and create new line. Once I got used to using these, it really sped me up since the cursor often doesn't end at the end of the line when you're coding, and we need semicolons there!

Here's what my my `keybindings.js` looks like:
```js
[
    { "key": "ctrl+;",   "command": "extension.toggleSemicolon", "when": "editorTextFocus" },
    { "key": "shift+ctrl+;",   "command": "runCommands", "when": "editorTextFocus", "args": {"commands": ["extension.toggleSemicolon", "editor.action.insertLineAfter"]} }
]
```