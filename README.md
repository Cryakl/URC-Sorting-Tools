<h1>📦 URC Sorting Tools</h1><br> 

<!-- Hey everyone, thanks for being part of the journey. When I first got this account from a friend, he didn't really think it'd get anywhere.  -->
<!-- I just wanted to see a genuine archive of RAT samples on the net for researchers, most collections I had seen had been were not very good.  -->
<!-- They purposefully backdoored RATs with their own payloads, their releases had been infected with a file-infector like Neshta, etc.          -->
<!--                                                                                                                                             -->
<!-- They never even included multiple versions or any historical versioning, so I decided to make this repository as complete as possible.      -->
<!-- Just so it could provide researchers or analysts with insight into how malware evolved over time, or even for nostalgia, NetBus, etc.       -->
<!--                                                                                                                                             -->
<!-- It was all a lot of fun and a big journey. But I think i've gotten bored of maintaining this all, soon someone I trust will take over.      -->
<!-- Anyways, peace out all of you. You've all made my life worthwile to live. ✌️                                            - The C.R.Y himself -->

> [!NOTE]  
> This repository contains a small collection of utilities for speeding up archiving samples.  
> Mainly leaving this here as I plan to let someone else take ownership of my GitHub soon.  

<h1></h1>

### Included Tools:
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

### Requirements:
- Windows, this isn't designed for Mac or Linux sadly.  
- [7-Zip](https://www.7-zip.org/download.html) for the mass folder compressor tool.  

<h1></h1>

### Where do you collect your samples?
  It's something that came with a long era of collecting, places open and close many times.  
  I'll list some sources i've used historically:  
  - GitHub
  - 4Shared
  - Mediafiretrend
  - Old YouTube videos
  - Archive.org
  - MegaSecurity
  - Connect-Trojan (Defunct)
  - Telegram
  - Hacking Forums
  - My Community

### How do you analyze these or check them?  
  This is also something I learned over a long time and can't really teach properly.  
  I'll list most tools i've used below:  
  - [VMWare](https://www.vmware.com/)
  - [Wireshark](https://www.wireshark.org/)
  - [Suricata](https://suricata.io/)
  - [RegShot](https://github.com/Seabreg/Regshot)
  - [Process Hacker 2](https://sourceforge.net/projects/processhacker/)
  - [Process Explorer](https://learn.microsoft.com/en-us/sysinternals/downloads/process-explorer)
  - [AutoRuns](https://learn.microsoft.com/en-us/sysinternals/downloads/autoruns)
  - [dnSpy](https://github.com/dnSpyEx/dnSpy)
  - [IDA](https://hex-rays.com/ida-pro)
  - [DIE](https://github.com/horsicq/Detect-It-Easy)
  - [HxD](https://mh-nexus.de/en/hxd/)
  - [Any.run](https://any.run/)
  - [Tria.ge](https://tria.ge/)
  - [Intezer](https://intezer.com/)

<h1></h1>

No license needed, feel free to modify, share, fork, do anything you like with this repo.
