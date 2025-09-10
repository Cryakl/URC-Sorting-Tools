<h1>URC Sorting Tools</h1><br>

> [!NOTE]  
> This repository contains a small collection of utilities for speeding up archiving samples and automating parts of it.  
> Mainly leaving this here as I plan to let someone else take ownership of my GitHub soon, thank you for all your support.

<h1></h1>

### Included Tools
- **[Batch] 🗜️ Mass Folder Compressor**  
  This script is pretty useful when you don't want to get RSI from 7-Zip's UI.  
  Instead of manually compressing folders one by one, this loops through all of them and does it for you.  
  In my version, it's already configured to compress at the maximum level and with the password 'infected'.  
  
- **[Batch] 📁 7Z Moving Utility**  
  This script is mostly useless, it's just used alongside the compressor personally.  
  It scans the current folder it's in for 7Z files and moves them into folders with the same name.  
  An example of what happens after it's run: **C:\Sample.7z → C:\Sample\Sample.7z**  
  
- **[C#] 📜 Automatic README Creator**  
  A small but neat C# utility that generates screenshot README's for you quickly.  
  When run in the root, it searches every folder for a "Screenshot.png" image and creates a README with it.  
  It avoids overwriting any existing READMEs, so you can easily add your own info without ruining it all.  
  
<h1></h1>

### 🪄 Requirements
- Windows, this isn't designed for Mac or Linux sadly.  
- [7-Zip](https://www.7-zip.org/download.html) for the mass folder compressor tool.  

<h1></h1>

No license needed, feel free to modify, share, fork, do anything you like with this repo.
