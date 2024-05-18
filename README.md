## Solution de Numerisation de Documents : 
##### Description
###### Technologies utilisées
* Backend (API) :
ASP.NET Core : 
* Frontend (Web) :
Vue js 


## Installation et exécution de l'application Sdnd

##### Prérequis

Avant de commencer, assurez-vous d'avoir les éléments suivants installés sur votre machine :

* .NET 8 SDK
* Node.js
* NPM

##### Étapes

1. **Ouvrez la solution Sdnd/Sdnd-api dans votre IDE préféré.**
2. **Restaurez les packages NuGet:**

```
dotnet restore
```

3. **Configurez la chaîne de connexion à la base de données dans le fichier appsettings.json.**
4. **Exécutez les migrations pour créer le schéma de la base de données:**

```
dotnet tool install --global dotnet-ef
dotnet ef migrations add "migrationName"
dotnet ef database update
```

5. **Démarrez l'API:**

```
dotnet run
```

6. **Configurez le frontend web:**

    * Ouvrez la solution Sdnd/Sdnd-ui.
    * Installez les packages NPM:

```
npm install
```

8. **Démarrez le serveur web:**

```
npm run serve
```

