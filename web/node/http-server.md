# Un simple serveur web

## 1. Installer Node

### macOS
Dans le Terminal:

```bash
curl "https://nodejs.org/dist/latest/node-${VERSION:-$(wget -qO- https://nodejs.org/dist/latest/ | sed -nE 's|.*>node-(.*)\.pkg</a>.*|\1|p')}.pkg" > "$HOME/Downloads/node-latest.pkg" && sudo installer -store -pkg "$HOME/Downloads/node-latest.pkg" -target "/"
```
(voir https://nodejs.org/en/download/package-manager/#macos)

### Windows (solution simple, mais...)
J'ai pas toujours eu une bonne expérience avec node/npm sous Windows, donc j'ai tendance à à plutôt passer par la solution suivante (Windows via Linux). 

Mais si jamais :
Passez par l'installeur disponible ici : https://nodejs.org/en/#home-downloadhead (la version "Current").

Installez le [Windows Terminal](https://aka.ms/terminal) (simple) ou [ConEmu](https://conemu.github.io/) (plus avancé mais plus complexe) pour disposer d'un terminal plus agréable que celui installé par défaut sous Windows.

### Windows via Linux (solution safe)
Cela installe un Linux minimal, accessible relativement facilement et bien intégré à Windows. Vous bénéficiez de tous les outils (en ligne de commande) disponibles sous Linux, et donc d'un environnement assez standard pour tout ce qui tourne autour des serveurs web et du développement en général.
Seul désavantage : ça utilise un peu plus d'espace disque que d'installer directement Node.

#### Étape préalable : Installer Debian
C'est une version de Linux

1. Dans le Microsoft Store, cherchez [Debian](https://www.microsoft.com/fr-fr/p/debian/9msvkqc78pk6).

2. Installez
    - Si ça ne fonctionne pas directement, il faut activer le "Windows Subsystem for Linux" [en suivant ces instructions](https://docs.microsoft.com/fr-fr/windows/wsl/install-win10#manual-installation-steps) (la version WSL2 est idéale, mais pas indispensable)

3. Il devrait maintenant y avoir un raccourci "Debian" dans votre menu démarrer.
    - [Quand il va vous demander votre mot de passe la première fois](https://docs.microsoft.com/fr-fr/windows/wsl/user-support), rien ne va s'afficher dans le Terminal quand vous écrivez le mot de passe. C'est normal :) (continuez à taper)
    
#### Étape confort : Installer un **bon** terminal
Installez le [Windows Terminal](https://aka.ms/terminal) (simple) ou [ConEmu](https://conemu.github.io/) (plus avancé mais plus complexe) pour disposer d'un terminal plus agréable que celui installé par défaut sous Windows.

- Le **Windows Terminal** permet d'ouvrir Debian dans un nouvel onglet. 
    - Vous pouvez également, dans les paramètres, sélectionner Debian comme "Profil par défaut"

- **ConEmu** permet d'ouvrir Debian dans un nouvel onglet (icône ➕ -> Bash -> Debian). 
    - Dans les Settings -> Startup -> Tasks, vous pouvez sélectionner Bash comme "Default Task for new console".
    - Vous pouvez ajouter la possibilité de lancer Debian à partir de l'Explorateur de Windows, en cliquant droit sur un dossier. Comment faire? 
        - Settings de ConEmu -> Integration
            - Menu item : par exemple `Debian ici!`
            - Command: `-reuse -run {Bash::DEBIAN} -cur_console:n`
            - Appuyez sur Register

#### Et enfin : Installer Node dans Debian
 Taper les commandes suivantes (une ligne à la fois, dans l'ordre).
 Dans le Windows Terminal et dans ConEmu, "coller" se fait avec un clic droit dans la fenêtre!
 
 ```bash
curl -fsSL https://deb.nodesource.com/setup_current.x | sudo bash -
sudo apt install -y nodejs
sudo apt install -y build-essential
```

## 2. Node http-server
Dans votre terminal et environnement de préférence (macOS, Windows, Linux), écrire : 

```bash
npm install --global http-server
```

Une fois l'installation réalisée avec succès, vous devriez pouvoir lancer un serveur web **dont la racine sera le dossier actuel** en écrivant dans le terminal de votre choix:
```bash
http-server
```

Le serveur sera accessible à l'adresse http://localhost:8080/ (uniquement accessible par vous)

(CTRL-C permet de tuer le serveur)

Pour lancer le serveur facilement à partir du bon dossier, plusieurs possibilités :

- Dans le Terminal macOS ou ConEmu, vous pouvez écrire `cd` (Change Directory), puis glisser dans le terminal le dossier dans lequel vous voulez aller, et Entrée.
    - Vous serez maintenant dans le bon dossier. De là, vous pouvez taper `http-server`pour le lancer.

- Dans le Terminal macOS ou ConEmu, vous pouvez écrire `http-server`, puis glisser dans le terminal le dossier dans lequel vous voulez aller, et Entrée.
    - Le serveur se lance à partir du dossier glissé

- Dans le Windows Terminal, si votre environnement par défaut (sélectionné dans les settings) est Debian, vous pouvez cliquer-droit sur un dossier dans l'Explorateur pour l'ouvrir dans le terminal
    - De là, vous pouvez taper `http-server`pour le lancer.

- Dans ConEmu, si vous avez configuré un "Debian ici!" dans Integration (voir plus haut), , vous pouvez cliquer-droit sur un dossier dans l'Explorateur pour l'ouvrir dans le terminal
    - De là, vous pouvez taper `http-server`pour le lancer.

**PROTIP** vous pouvez utiliser les flèches HAUT/BAS pour naviguer dans l'historique des commandes, et répéter une commande précédente :)