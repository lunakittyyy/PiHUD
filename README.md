# PiHUD
PiHUD is a (currently CLI) heads-up system display intended for the Raspberry Pi, however it will work anywhere where the client and the server can be connected via LAN (or the internet?)

> [!WARNING]  
> This is not designed to be flexible or work for everyone. It was designed for me. :)

![IMG_2311](https://github.com/user-attachments/assets/db36da99-4e1c-493e-a251-9a729196340e)

## Features
- [ ] Stats bars
  - [x] CPU % bar
  - [x] RAM % bar
  - [ ] Swap % bar
  - [x] GPU % bar (NVIDIA only for now)
  - [X] Root disk usage % bar
- [ ] Text stats
  - [x] Kernel version, architecture
  - [x] Uptime
  - [x] CPU model
  - [x] GPU model (NVIDIA only for now)
  - [ ] Network interface Tx
  - [ ] Network interface Rx

## Requirements
- .NET 9
  ### Client
  - LAN connection
  - Any TTY or terminal emulator
  ### Server
  - LAN connection
  - Basic coreutils (sed, grep, free, etc.)
  - nvidia-smi (AMD GPU support will only come until I either personally get one or it is contributed)
