# PiHUD
PiHUD is a (currently CLI) heads-up system display intended for the Raspberry Pi, however it will work anywhere where the client and the sever can be connected via LAN (or the internet?)

# Hacking
This project consists of three main components: the Client, the Server, and the Core.

The Client and the Server are connected via WebSockets and the Client periodically asks the Server for updated info. The Server is hosted on the machine you wish to see stats of, usually as a systemd service.

**Both** the Client and the Server use the Core. The core defines things integral like configuration management and communication packets. Things not specific to the Client or the Server's behaviour in isolation to each other should be contained in the Core.