# FFmpeg
FFmpeg c'est le couteau suisse de la conversion vidéo.

C'est FFmpeg qui permet à VLC de lire tant de formats de vidéos.
C'est FFmpeg qui comprime les vidéos uploadées sur Youtube ou Vimeo.
FFmpeg se cache aussi dans Handbrake!

C'est un outil "en ligne de commande". Ça veut dire qu'il n'y a pas d'interface cliquable, juste des commandes texte à écrire dans un terminal qui peut sembler (de façon compréhensible) un peu rébarbatif.

Mais FFmpeg est un outil dont la puissance, l'efficacité et la flexibilité méritent qu'on fasse l'effort de la ligne de commande.


## 1. Installer FFmpeg
- Sous Windows, télécharger la dernier version statique 64bit [ici](https://ffmpeg.zeranoe.com/builds/)
- Sous macOS, télécharger la dernière version [ici](https://evermeet.cx/ffmpeg/)
- Sous Linux, sudo apt-get install ffmpeg

Si un des liens ci-dessus ne fonctionne plus, [se référer au site officiel FFmpeg](https://ffmpeg.org/download.html).

C'est une archive qui contient le programme (parfois placé dans un dossier /bin/). Pas d'installeur, il faut placer l'exécutable ffmpeg dans un endroit accessible.

- Sous Windows dans un dossier "ffmpeg" avec vos autres programmes (perso j'ai tendance à me créer un dossier PGM pour ce genre de choses, donc C:\PGM\ffmpeg).
- Sous macOS ... dans Applications?

## 2. Ouvrir 
Si vous double-cliquez sur l'application ffmpeg, vous allez juste voir un terminal s'ouvrir, et sans doute se fermer aussi tôt.
