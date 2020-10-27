# Éditer son profil Beaker
Votre profil Beaker, c'est un peu votre homepage (à l'ancienne, cf [Justin Hall](https://www.youtube.com/watch?v=AxD4mqFtySQ) ou [Geocities](https://oneterabyteofkilobyteage.tumblr.com/archive)). 

Appropriez-vous cet espace, faites-en un endroit pour vous présenter, ou pour partager des choses qui vous tiennent à coeur, qui semblent utiles ou importantes.
Ça doit pas être d'une grande envergure, c'est uniquement un petit exercice simple pour mettre en application votre HTML et CSS.

**Pour éditer ce profil, il existe 2 méthodes : **
1. Éditer directement dans Beaker
2. Exporter l'Hyperdrive, puis faire une synchronisation de dossier

Ça s'applique aussi à n'importe quelle Hyperdrive dont vous avez le contrôle, mais pour lequel vous n'avez pas encore les fichiers sur votre ordinateur.

**Dans tous les cas, la première étape** est d'accéder à votre profil. La façon la plus directe et de cliquer sur l'icône avec votre avatar, qui se trouve en haut à droite

![profil.png](img\profil.png)

---

## 1. Éditer directement dans Beaker

 Éditer directement a l'avantage d'être rapide, de vous mettre directement dedans. Mais vous ne bénéficiez pas de tous les avantages d'un outil comme Brackets.
 
 Il suffit de cliquer sur l'icône Editor dans la barre de raccourcis
 
 ![editortopleft.png](img\editortopleft.png)
également accessible avec le raccourci CTRL-B (CMD-B sur Mac). 
(B comme "Bditor" bien sûr...)

Là s'ouvre un éditeur similaire à Brackets ou Sublime, avec une liste de fichiers à gauche, et le code à droite.

Vous pouvez modifier vos fichiers directement.

Votre site contient au minimum 3 fichiers:
- un fichier index.html : votre page d'accueil
- un fichier index.json : des infos à propos de votre profil (utilisé par Beaker et son carnet d'adresse, à ne pas effacer!)
- thumb.png : votre avatar

Il est possible d'y trouver d'autres fichiers, si vous avez utilisé des applications Beaker qui ajoutent des fichiers dans votre profil (comme par exemple [Blahbity-blog](hyper://a8e9bd0f4df60ed5246a1b1f53d51a1feaeb1315266f769ac218436f12fda830/), un microblog qui sauve vos propres posts dans le dossier /microblog de votre profil).

## 2. Travailler plutôt avec la synchronisation
Avec l'éditeur ouvert (voir 1.), vous pouvez exporter le contenu de l'Hyperdrive.

Cliquez droit dans un espace vide de la liste de fichiers, et sélectionnez "Export files"
![exportfiles.png](img\exportfiles.png)

Exportez dans un dossier vide!

Fermez l'éditeur (travailler dans l'éditeur + la synchro semble une mauvaise idée).

Activez la synchronisation avec le dossier où vous avez téléchargé 
![syncwithlocalfolder.png](img\syncwithlocalfolder.png)
et activez l'auto-synchronisation
![startauto5.png](img\startauto5.png)

Maintenant, vous pouvez ouvrir ce dossier comme projet Beaker, et commencer à travailler! 

Le profil créé par défaut dans Beaker met la CSS directement dans l'HTML (c'est autorisé, mais pas idéal), je vous recommande donc de commencer par créer un fichier CSS (par exemple style.css) et de le lier à votre document HTML avec un élément <link> dans le head : 
~~~html
<link rel=stylesheet href="style.css">
~~~

N'hésitez pas à vous inspirer de [ce que j'ai commencé à faire sur mon profil](hyper://fdb55c1075137a3f86c6f6aee039c455f3962d17a48b03477d8b468f63dab56d/), c'est gratuit!
(la css, typos et images sont dans le dossier "assets")

